import json
import os
import socket
import threading

from db_verificador import ConexionBD
from procesador_verificador import procesar_cliente

CONFIG_PATH = os.path.join(os.path.dirname(os.path.abspath(__file__)), "Config.json")

def cargar_configuracion(path: str) -> dict:
    with open(path, "r", encoding="utf-8") as archivo:
        return json.load(archivo)

def manejar_cliente(conexion, direccion, conexion_bd):
    with conexion:
        datos = conexion.recv(4096)
        if not datos:
            return

        try:
            trama = json.loads(datos.decode("utf-8"))
            respuesta = procesar_cliente(trama, conexion_bd)
        except (json.JSONDecodeError, KeyError)as error:
            print("ERROR JSON/KEY: ", error)
            respuesta = {"status": "1"}
        except Exception:
            print("ERROR GENERAL:", error)
            respuesta = {"status": "4"}

        conexion.sendall(json.dumps(respuesta).encode("utf-8"))

def iniciar_servidor(host, port, conexion_bd):
    with socket.socket(socket.AF_INET, socket.SOCK_STREAM) as servidor:
        servidor.setsockopt(socket.SOL_SOCKET, socket.SO_REUSEADDR, 1)
        servidor.bind((host, port))
        servidor.listen()

        while True:
            conexion, direccion = servidor.accept()
            hilo = threading.Thread(
                target=manejar_cliente,
                args=(conexion, direccion, conexion_bd),
                daemon=True
            )
            hilo.start()

if __name__ == "__main__":
    configuracion = cargar_configuracion(CONFIG_PATH)
    conexion_bd = ConexionBD(configuracion["mysql"])
    iniciar_servidor(configuracion["host"], configuracion["port"], conexion_bd)
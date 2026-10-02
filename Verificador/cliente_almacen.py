import socket

def construir_trama_salida(numero_factura, fecha_venta, productos):
    tipo = "6"
    factura = str(numero_factura).zfill(10)
    fecha = fecha_venta

    cuerpo_productos = ""
    for producto in productos:
        codigo = str(producto["codigo_producto"]).zfill(10)
        cantidad = str(producto["cantidad"]).zfill(7)
        cuerpo_productos += codigo + cantidad

    return tipo + factura + fecha + cuerpo_productos

def enviar_salida_almacen(host, port, numero_factura, fecha_venta, productos):
    trama = construir_trama_salida(numero_factura, fecha_venta, productos)

    with socket.socket(socket.AF_INET, socket.SOCK_STREAM) as cliente:
        cliente.connect((host, port))
        cliente.sendall(trama.encode("utf-8"))
        respuesta = cliente.recv(4096)
        return respuesta.decode("utf-8")
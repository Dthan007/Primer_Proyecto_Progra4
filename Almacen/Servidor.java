import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;
import java.net.ServerSocket;
import java.net.Socket;
import java.nio.charset.StandardCharsets;

public class Servidor {

    private static final int PUERTO = 5000;

    public static void main(String[] args) {

        try (ServerSocket servidor = new ServerSocket(PUERTO)) {

            System.out.println("Servidor iniciado en el puerto " + PUERTO);

            while (true) {

                Socket cliente = servidor.accept();

                System.out.println("Cliente conectado");

                atenderCliente(cliente);
            }

        } catch (IOException ex) {

            System.out.println("Error del servidor: " + ex.getMessage());
        }
    }

    private static void atenderCliente(Socket cliente) {

        try (
            Socket socket = cliente;
            InputStream entrada = socket.getInputStream();
            OutputStream salida = socket.getOutputStream()
        ) {

            byte[] buffer = new byte[1024];

            while (true) {

                int cantidadBytes = entrada.read(buffer);

                if (cantidadBytes == -1) {
                    System.out.println("Cliente desconectado");
                    break;
                }

                String mensaje = new String(
                    buffer,
                    0,
                    cantidadBytes,
                    StandardCharsets.UTF_8
                );

                System.out.println("Mensaje recibido: " + mensaje);

                String respuesta = "Hola desde el servidor Java";

                byte[] datosRespuesta =
                    respuesta.getBytes(StandardCharsets.UTF_8);

                salida.write(datosRespuesta);
                salida.flush();
            }

        } catch (IOException ex) {

            System.out.println("Error con el cliente: " + ex.getMessage());
        }
    }
}

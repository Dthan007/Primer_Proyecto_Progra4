using System.Net.Sockets;
using System.Text;

namespace Sistema_de_Ventas_y_Distribución
{
    public class ConexionSocket
    {
        private TcpClient clienteTCP;
        private NetworkStream streamNW;

        private readonly string ipServidor = "127.0.0.1";
        private readonly int puertoServidor = 5000;

        public bool Conectar()
        {
            try
            {
                clienteTCP = new TcpClient();
                clienteTCP.Connect(ipServidor, puertoServidor);

                streamNW = clienteTCP.GetStream();
                MessageBox.Show("Conectado al servidor de Java.");

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                "Error al conectar con el servidor Java:\n" + ex.Message,
                "Error de conexión",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );

                return false;
            }
        }

        public void Enviar(string mensaje) 
        {
            MessageBox.Show("No existe conexión con el servidor Java.");
            return;

            byte[] datos = Encoding.UTF8.GetBytes(mensaje);

            streamNW.Write(datos, 0, datos.Length);

        }//Enviar.

        public string Recibir() 
        {
            if (streamNW == null) 
            {
                MessageBox.Show("No existe conexión con el servidor Java.");
                return null;
            }

            byte[] buffer = new byte[1024];

            int cantidad = streamNW.Read(buffer, 0, buffer.Length);

            return Encoding.UTF8.GetString(buffer, 0, cantidad);

        }//Recibir.

        public void Desconectar()
        {
            streamNW?.Close();
            clienteTCP?.Close();

            streamNW = null;
            clienteTCP = null;
        }
    }
}//Sistema_de_Ventas_y_Distribución.

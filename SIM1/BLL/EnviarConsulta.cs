namespace BLL
{
    public class EnviarConsulta
    {
        public string ProcesarElemento(string trama)
        {
            ConexionSocket socket = new ConexionSocket("127.0.0.1", 5000);

            if (!socket.Conectar())
            {
                return "ERROR: No se pudo conectar con Java.";
            }

            return socket.EnviarYRecibir(trama);
        }
    }
}

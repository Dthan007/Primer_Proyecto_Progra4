namespace BLL
{
    public class NuevoProveedorbll
    {
        public string ConstruirTrama(Entity.NuevoProveedor proveedor)
        {
            string trama =
                "PROVEEDOR|" +
                proveedor.tipoTransaccion + "|" +
                proveedor.IDjuridica + "|" +
                proveedor.nombreEmpresa + "|" +
                proveedor.nombreContacto + "|" +
                proveedor.telefono + "|" +
                proveedor.correo + "|" +
                proveedor.estado;
            return trama;
        }
        public string ProcesarProveedor(Entity.NuevoProveedor proveedor)
        {
            string trama = ConstruirTrama(proveedor);
            ConexionSocket socket = new ConexionSocket("127.0.0.1", 5000);

            if (!socket.Conectar())
            {
                return "ERROR: No se pudo conectar con Java.";
            }

            string respuesta = socket.EnviarYRecibir(trama);

            socket.Desconectar();

            return respuesta;
        }
    }
}

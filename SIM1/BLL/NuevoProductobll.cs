

namespace BLL
{
    public class NuevoProductobll
    {
        public string ConstruirTrama(Entity.NuevoProducto producto)
        {
            string trama =
                "PRODUCTO|" +
                producto.transaccion + "|" +
                producto.producto + "|" +
                producto.nombre + "|" +
                producto.precio;

            return trama;
        }

        public string ProcesarProducto(Entity.NuevoProducto producto)
        {
            string trama = ConstruirTrama(producto);

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

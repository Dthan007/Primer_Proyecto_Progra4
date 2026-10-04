namespace BLL
{
    public class CompraProveedorbll
    {
        public string ConstruirTrama(Entity.CompraProveedor compraProveedor)
        {
            string trama =
                "COMPRA_PROVEEDOR|" +
                compraProveedor.transaccion + "|" +
                compraProveedor.NoIngreso + "|" +
                compraProveedor.fecha.ToString("yyyy-MM-dd") + "|" +
                compraProveedor.listaProductos + "|" +
                compraProveedor.NoProducto + "|" +
                compraProveedor.cantidad;
            return trama;
        }


        public string procesarCompraProveedor(Entity.CompraProveedor compraProveedor)
        {
            string trama = ConstruirTrama(compraProveedor);
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

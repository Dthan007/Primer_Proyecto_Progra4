package BLL;

import Entity.NuevoProducto;
import DAL.ProductoDAL;

public class ProductoBLL 
{
    private ProductoDAL productoDAL = new ProductoDAL();

    public String procesoTrama(String trama)
    {
        String[] datos = trama.split("\\|");

        if (datos.length != 5)
        {
            return "La información recibida no es válida";
        }

        if (!datos[0].equals("PRODUCTO"))
        {
            return "Operación no válida";
        }

        try
        {
            int transaccion = Integer.parseInt(datos[1]);
            String producto = datos[2];
            String nombre = datos[3];
            double precio = Double.parseDouble(datos[4]);

            NuevoProducto nuevoProducto =
                new NuevoProducto(
                    transaccion,
                    producto,
                    nombre,
                    precio
                );

            boolean resultado =
                productoDAL.guardarProducto(nuevoProducto);

            if (resultado)
            {
                return "EXITOSO";
            }
            else
            {
                return "ERROR";
            }
        }
        catch (NumberFormatException e)
        {
            return "Los datos del producto no son válidos";
        }
    }
}
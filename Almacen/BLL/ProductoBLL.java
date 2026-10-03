package BLL;

import Entity.NuevoProducto;
import DAL.ProductoDAL;

public class ProductoBLL 
{
    private ProductoDAL productoDAL = new ProductoDAL();

    public boolean procesoTrama(String trama)
    {
        String[] datos = trama.split("\\|");

        if (datos.length != 5)
        {
            return false;
        }

        if (!datos[0].equals("PRODUCTO"))
        {
            return false;
        }

        try 
        {
            int transaccion = Integer.parseInt(datos[1]);
            String producto = datos[2];
            String nombre = datos[3];
            double precio = Double.parseDouble(datos[4]);

            NuevoProducto nuevoProducto =
                new NuevoProducto(transaccion, producto, nombre, precio);

            // AQUÍ SE LLAMA A ProductoDAL
            return productoDAL.guardarProducto(nuevoProducto);


        }
        catch (NumberFormatException e) 
        {
            return false;
        }
    }
}
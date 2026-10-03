package DAL;

import Entity.NuevoProducto;
import java.sql.Connection;
import java.sql.CallableStatement;
import java.sql.DriverManager;

public class ProductoDAL {

    private final String url =
        "jdbc:sqlserver://localhost:1433;databaseName=Almacen;encrypt=false;trustServerCertificate=true;integratedSecurity=true";

    

    public boolean guardarProducto(NuevoProducto producto) {

        String sql = "{CALL SP_InsertarNuevoProducto(?, ?, ?, ?)}";

        try (
            Connection conexion = DriverManager.getConnection(
                url
            );

            CallableStatement comando =
                conexion.prepareCall(sql)
        ) {

            comando.setInt(1, producto.getTransaccion());
            comando.setString(2, producto.getProducto());
            comando.setString(3, producto.getNombre());
            comando.setDouble(4, producto.getPrecio());

            comando.execute();
            System.out.println("Filas afectadas: " + comando.getUpdateCount());

            return true;

        } catch (Exception e) {

            System.out.println(
                "Error al guardar producto: " + e.getMessage()
            );

            return false;
        }
    }
}

package DAL;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class ConexionSQL 
{

    private static final String URL = 
    "jdbc:sqlserver://localhost:1433;"
    + "databaseName=Almacen;"
    + "integratedSecurity=true;"
    + "encrypt=true;"
    + "trustServerCertificate=true;";

    public static Connection conectar()
    {
        try
        {
            Connection conexion = DriverManager.getConnection(URL);
            System.out.println("Conexión exitosa a SQL");
            return conexion;

        }
        catch(SQLException e)
        {
            System.out.println("Error al conectar SQL");
            e.printStackTrace();
            return null;

        }
    }
}
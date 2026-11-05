
package DAL;

import Entity.NuevaCompra;
import Entity.DetalleCompra;

import com.microsoft.sqlserver.jdbc.SQLServerCallableStatement;
import com.microsoft.sqlserver.jdbc.SQLServerDataTable;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Date;
import java.time.LocalDate;
import java.time.format.DateTimeFormatter;

public class CompraDAL {

    public String insertarCompra(NuevaCompra compra) {

        String sql = "{CALL SP_InsertarCompra(?, ?, ?, ?)}";

        try (
            Connection conexion = ConexionSQL.conectar();
            SQLServerCallableStatement comando =
                (SQLServerCallableStatement) conexion.prepareCall(sql)
        ) {

            DateTimeFormatter formato =
                DateTimeFormatter.ofPattern("yyyyMMdd");

            LocalDate fecha =
                LocalDate.parse(compra.getFechaCompra(), formato);

            Date fechaSQL = Date.valueOf(fecha);

            SQLServerDataTable detalles = new SQLServerDataTable();

            detalles.addColumnMetadata(
                "NoProducto", java.sql.Types.VARCHAR
            );

            detalles.addColumnMetadata(
                "Cantidad", java.sql.Types.INTEGER
            );

            for (DetalleCompra detalle : compra.getDetalles()) {

                detalles.addRow(
                    detalle.getNoProducto(),
                    detalle.getCantidad()
                );
            }

            comando.setString(1, compra.getNoIngreso());
            comando.setDate(2, fechaSQL);
            comando.setString(3, compra.getIdJuridica());

            comando.setStructured(
                4,
                "dbo.TipoDetalleCompra",
                detalles
            );

            try (ResultSet resultado = comando.executeQuery()) {

                if (resultado.next()) {
                    return resultado.getString("Resultado");
                }
            }

            return "ERROR: El procedimiento no devolvió respuesta.";

        } catch (Exception e) {

            System.out.println(
                "Error al insertar compra: " + e.getMessage()
            );

            return "ERROR: " + e.getMessage();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entity;

namespace Data
{
    public class RegionData
    {
        public void RegistrarRegionData(RegionEntity regionentity)
        {
            using (var connection = new SqlConnection(Coneccion.cadena))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("sp_crear_region", connection);
                command.CommandType = CommandType.StoredProcedure;

                //  enviar parametros
                SqlParameter parameter = new SqlParameter("@RegionName", SqlDbType.VarChar, 100);
                parameter.Value = regionentity.RegionName;
                command.Parameters.Add(parameter);

                command.ExecuteNonQuery();
            }
        }

        public List<RegionEntity> ListarRegionData(RegionEntity regionentity)
        {
            List<RegionEntity> roles = new List<RegionEntity>();
            using (var connection = new SqlConnection(Coneccion.cadena))
            {
                // usar le meotdo almacenado
                SqlCommand cmd = new SqlCommand("sp_listar_region", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                // enviar los  parametros
                SqlParameter paraameter = new SqlParameter("@RegionName", SqlDbType.VarChar, 100);
                paraameter.Value = regionentity.RegionName;
                cmd.Parameters.Add(paraameter);

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                //recorremos el DATA READER
                while (reader.Read())
                {
                    int RegionId = reader["RegionId"] != DBNull.Value ? Convert.ToInt32(reader["RegionId"]) : 0;

                    string RegionName = reader["RegionName"] != DBNull.Value ? Convert.ToString(reader["RegionName"]) : "";

                    roles.Add(new RegionEntity { RegionId =  RegionId, RegionName=  RegionName});
                }

                reader.Close();
            }
            return roles;
        }

        public void ActualizarRegionData(RegionEntity regionentity)
        {
            using (var connection = new SqlConnection(Coneccion.cadena))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("sp_actualizar_region", connection);
                cmd.CommandType= CommandType.StoredProcedure;

                //  pasamos los parametros
                SqlParameter parameter = new SqlParameter("@RegionId", SqlDbType.Int);
                parameter.Value = regionentity.RegionId;
                cmd.Parameters.Add(parameter);

                SqlParameter paramater1 = new SqlParameter("@RegionName", SqlDbType.VarChar, 100);
                paramater1.Value = regionentity.RegionName;
                cmd.Parameters.Add(paramater1);

                SqlParameter paramater2 = new SqlParameter("@Enabled", SqlDbType.Bit);
                paramater2.Value = regionentity.Enabled;
                cmd.Parameters.Add(paramater2);

                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarRegionData(RegionEntity regionEntity)
        {
            using (var connection =  new SqlConnection(Coneccion.cadena))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("sp_eliminar_region", connection);
                cmd.CommandType =  CommandType.StoredProcedure;

                //  parametrso
                SqlParameter parameter = new SqlParameter("@RegionId", SqlDbType.Int);
                parameter.Value = regionEntity.RegionId;
                cmd.Parameters.Add(parameter);

                cmd.ExecuteNonQuery();
            }
        }
    }
}

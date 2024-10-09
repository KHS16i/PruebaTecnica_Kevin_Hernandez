using System.Collections.Generic;
using System.Data;
using System;
using System.Data.SqlClient;
using UX.Modelos;
using System.Configuration;

namespace UX.Logica
{
    public class AccesoDatos
    {
        public List<SaldoAsignado> AsignarSaldos(string saldos)
        {
            List<SaldoAsignado> saldoAsignado = new List<SaldoAsignado>();

            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["connection_string"].ToString()))
            {
                using (var cmd = new SqlCommand("usp_AsignaSaldos", cnx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@saldos_desordenados", saldos));

                    try
                    {
                        cnx.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                saldoAsignado.Add(new SaldoAsignado(reader));
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                }
            }

            return saldoAsignado;
        }
    }
}

using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public class UsuarioServicio
{
   
    private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

    
    public Usuario Login(string correo, string password)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            using (SqlCommand cmd = new SqlCommand("sp_Usuario_Login", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@correo", correo);
                cmd.Parameters.AddWithValue("@passwordd", password);

                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Usuario
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Nombres = reader["Nombres"].ToString(),
                            Correo = reader["Correo"].ToString(),
                            Passwordd = reader["Passwordd"].ToString()
                        };
                    }
                }
            }
        }
        return null;
    }

 
    public bool Registrar(string nombres, string correo, string password)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            using (SqlCommand cmd = new SqlCommand("sp_Usuario_Insert", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombres", nombres);
                cmd.Parameters.AddWithValue("@correo", correo);
                cmd.Parameters.AddWithValue("@passwordd", password);

                con.Open();
                int filasAfectadas = cmd.ExecuteNonQuery();

                return filasAfectadas > 0;
            }
        }
    }
}


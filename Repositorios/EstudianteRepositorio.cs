
using SistemaRegistroNotas.Clases;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace SistemaRegistroNotas.Repositorios
{
    public class EstudianteRepositorio
    {
        private readonly string cadenaConexion =
            @"Server=.\SQLEXPRESS;Database=SistemaRegistroNotas;Trusted_Connection=True;TrustServerCertificate=True;";

        public List<Estudiante> ObtenerTodos()
        {
            var estudiantes = new List<Estudiante>();

            using (var conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();

                string sql = @"SELECT Id, Nombre, Apellido, Codigo,
                                      Laboratorio, Parcial, Asistencia, NotaFinal
                               FROM dbo.Estudiante";

                using (var comando = new SqlCommand(sql, conexion))
                using (var lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        estudiantes.Add(new Estudiante
                        {
                            Id = Convert.ToInt32(lector["Id"]),
                            Nombre = lector["Nombre"].ToString(),
                            Apellido = lector["Apellido"].ToString(),
                            Codigo = lector["Codigo"].ToString(),
                            Laboratorio = Convert.ToDecimal(lector["Laboratorio"]),
                            Parcial = Convert.ToDecimal(lector["Parcial"]),
                            Asistencia = Convert.ToDecimal(lector["Asistencia"]),
                            NotaFinal = Convert.ToDecimal(lector["NotaFinal"])
                        });
                    }
                }
            }

            return estudiantes;
        }

        public void Agregar(Estudiante estudiante)
        {
            using (var conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();

                string sql = @"INSERT INTO dbo.Estudiante
                    (Nombre, Apellido, Codigo, Laboratorio, Parcial,
                     Asistencia, NotaFinal)
                    VALUES
                    (@Nombre, @Apellido, @Codigo, @Laboratorio, @Parcial,
                     @Asistencia, @NotaFinal)";

                using (var comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@Nombre", estudiante.Nombre);
                    comando.Parameters.AddWithValue("@Apellido", estudiante.Apellido);
                    comando.Parameters.AddWithValue("@Codigo", estudiante.Codigo);
                    comando.Parameters.AddWithValue("@Laboratorio", estudiante.Laboratorio);
                    comando.Parameters.AddWithValue("@Parcial", estudiante.Parcial);
                    comando.Parameters.AddWithValue("@Asistencia", estudiante.Asistencia);
                    comando.Parameters.AddWithValue("@NotaFinal", estudiante.NotaFinal);

                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Actualizar(Estudiante estudiante)
        {
            using (var conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();

                string sql = @"UPDATE dbo.Estudiante
                    SET Nombre = @Nombre,
                        Apellido = @Apellido,
                        Codigo = @Codigo,
                        Laboratorio = @Laboratorio,
                        Parcial = @Parcial,
                        Asistencia = @Asistencia,
                        NotaFinal = @NotaFinal
                    WHERE Id = @Id";

                using (var comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@Id", estudiante.Id);
                    comando.Parameters.AddWithValue("@Nombre", estudiante.Nombre);
                    comando.Parameters.AddWithValue("@Apellido", estudiante.Apellido);
                    comando.Parameters.AddWithValue("@Codigo", estudiante.Codigo);
                    comando.Parameters.AddWithValue("@Laboratorio", estudiante.Laboratorio);
                    comando.Parameters.AddWithValue("@Parcial", estudiante.Parcial);
                    comando.Parameters.AddWithValue("@Asistencia", estudiante.Asistencia);
                    comando.Parameters.AddWithValue("@NotaFinal", estudiante.NotaFinal);

                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}

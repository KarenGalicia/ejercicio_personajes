using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver.Core.Configuration;
using MySql.Data.MySqlClient;

namespace ejercicio_personajes.DATA.DataAccess
{
    internal class Personajes
    {
        private string connectionString = "Server=localhost;Database=db_universidad;Uid=root;Pwd=123Pk2..";
        public bool ProbarConexion()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                try
                {



                    connection.Open();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }



            }

        }
        public DataTable LeerPersonajes()
        {

            DataTable personajes = new DataTable();


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {







                connection.Open();


                string sql = "Select * from personajes_dragon_ball";

                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {


                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {



                        adapter.Fill(personajes);

                    }



                }


            }
            return personajes;



        }


        public int CrearPersonaje(string nombre, string raza, int nivelPoder, DateTime Fecha, string historia)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "INSERT INTO personajes_dragon_ball (nombre, raza, nivel_poder, Fecha, historia) VALUES (@nombre, @raza, @nivelPoder, @Fecha, @historia )";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@raza", raza);
                    command.Parameters.AddWithValue("@nivelPoder", nivelPoder);
                    command.Parameters.AddWithValue("@historia", historia);
                    command.Parameters.AddWithValue("@Fecha", Fecha);

                    return command.ExecuteNonQuery();
                }
            }
        }


        //Busca un personaje por su ID
        public DataTable BuscarPersonajePorId(int id)
        {
            DataTable personaje = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM personajes_dragon_ball WHERE id = @id";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(personaje);
                    }
                }
            }

            return personaje;
        }


      


    // Método para actualizar un personaje
    public void ActualizarPersonaje(int id, string nombre, string raza, int nivelPoder, DateTime Fecha, string historia)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "UPDATE personajes_dragon_ball SET nombre = @nombre, raza = @raza, nivel_poder = @nivelPoder, fecha_creacion = @fechaCreacion, historia = @Historia WHERE id = @id";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@raza", raza);
                    command.Parameters.AddWithValue("@nivelPoder", nivelPoder);
                    command.Parameters.AddWithValue("@Fecha", Fecha);
                    command.Parameters.AddWithValue("historia", historia);
                    command.ExecuteNonQuery();
                }
            }
        }

        // Método para eliminar un personaje
        public void EliminarPersonaje(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "DELETE FROM personajes_dragon_ball WHERE id = @id";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    command.ExecuteNonQuery();
                }
            }
        }



        //si da tiempo:
        // Función para ejecutar consultas SQL genéricas
        public DataTable EjecutarConsulta(string consultaSQL)
        {
            DataTable resultado = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(consultaSQL, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(resultado);
                    }
                }
            }

            return resultado;
        }





    }
}

   

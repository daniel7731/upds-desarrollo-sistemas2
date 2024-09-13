using MySqlConnector;
using System.Collections.Generic;
using System.ComponentModel;
using WebApplicationAcademia.Model;

namespace WebApplicationAcademia.Data
{
    public class DaoAlumno
    {
        private string connectionString = "";
        
        public DaoAlumno() {

            this. connectionString = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("ConnectionStrings")["DefaultConnection"];
        }
        public List<Alummno> getAll()
        {
            List<Alummno> alummnos = new List<Alummno>();
            using (MySqlConnection connection = new MySqlConnection(this.connectionString))
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand("SELECT * FROM alumno", connection);

                // Execute the command and retrieve results
               
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Process the retrieved data
                        Alummno e = new Alummno();       
                        e.id = int.Parse(reader["id"].ToString());
                        e.nombre = reader["nombre"].ToString();
                        e.apellido1 = reader["apellido1"].ToString();
                        e.apellido2 = reader["apellido2"].ToString();
                        e.fechaModificacion = DateTime.Parse(reader["fechaMod"].ToString());
                        e.fechaNacimiento = DateTime.Parse(reader["fechaNac"].ToString());
                        e.fechaRegistro = DateTime.Parse(reader["fechaReg"].ToString());
                        alummnos.Add(e); 
                    }
                }
            }
            return alummnos;
        }

        public Alummno registrarAlumno(Alummno alummno)
        {
            using (MySqlConnection connection = new MySqlConnection(this.connectionString))
            {

                connection.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO `academia`.`alumno`(nombre,apellido1,apellido2,fechaNac,fechaMod,fechaReg) " +
                    "VALUES(@nombre,@apellido1,@apellido2,@fechaNac,@fechaMod,@fechaReg)", connection);


                command.Parameters.AddWithValue("@nombre", alummno.nombre);
                command.Parameters.AddWithValue("@apellido1", alummno.apellido1);
                command.Parameters.AddWithValue("@apellido2", alummno.apellido2);
                command.Parameters.AddWithValue("@fechaNac", alummno.fechaNacimiento);
                command.Parameters.AddWithValue("@fechaMod", alummno.fechaModificacion);
                command.Parameters.AddWithValue("@fechaReg", alummno.fechaRegistro);
                command.ExecuteNonQuery();
            }
            return alummno;
        }
        public bool actualizarAlummno(int id ,Alummno alummno) {

            try
            {
                using (MySqlConnection connection = new MySqlConnection(this.connectionString))
                {

                    connection.Open();
                    MySqlCommand command = new MySqlCommand("UPDATE `academia`.`alumno` set  nombre =@nombre, apellido1= @apellido1," +
                        " apellido2=@apellido2, fechaNac =@fechaNac" +
                        " where id = @id ", connection);


                    command.Parameters.AddWithValue("@nombre", alummno.nombre);
                    command.Parameters.AddWithValue("@apellido1", alummno.apellido1);
                    command.Parameters.AddWithValue("@apellido2", alummno.apellido2);
                    command.Parameters.AddWithValue("@fechaNac", alummno.fechaNacimiento);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }catch(Exception ex)
            {

            }


            return false;
        }
        
    }
}

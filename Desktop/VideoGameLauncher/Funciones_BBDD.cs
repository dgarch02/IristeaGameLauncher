using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoGameLauncher
{
    class Funciones_BBDD
    {
        //Instanciar sqlConnection con la conexion del App.config
        private SqlConnection conexion = new SqlConnection(
           ConfigurationManager.ConnectionStrings["VideoGameLauncher.Properties.Settings.VideoJuegosIristeaConnectionString"].ConnectionString
        );

        //Inserto los datos de configuracion y me devuelve el id del jugador
        public int insertarDatosYObtenerID(Datos objeto)
        {

            using (SqlCommand cmd = new SqlCommand("INSERT INTO Juegos (juego, estado) output INSERTED.ID VALUES (@juego, @estado)", conexion))
            {
                //Pasamos los datos a un string
                string json = JsonConvert.SerializeObject(objeto);

                //El estado del juego a 0 jugando a 1 finalizado
                int jugando = 0;

                //Limpiamos los parametros del sqlcomand
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@juego", json);
                cmd.Parameters.AddWithValue("@estado", jugando);

                //Abrir la conexion
                conexion.Open();

                //Guardamos el id del jugador
                int idJugador = (int)cmd.ExecuteScalar();

                if (conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();

                return idJugador;
            }

        }

        //Leo los resultados de la partida
        public Resultados leerResultados(int id)
        {

            //Instruccion sql para leer los resultados del id indicado
            string query = "SELECT resultados FROM Juegos WHERE id=@id";

            //Abrir la conexion
            conexion.Open();

            //Ejecutamos la instruccion pasandole la conexion de la base de datos
            SqlCommand command = new SqlCommand(query, conexion);

            //Limpiamos los parametros del sqlcomand
            command.Parameters.Clear();

            //Insertamos el id como parametro
            command.Parameters.AddWithValue("@id", id);

            //Guardamos los resultados en la variable resultados
            using (SqlDataReader reader = command.ExecuteReader())
            {
                Resultados result = new Resultados();
                string resultados = "";
                while (reader.Read())
                {

                    resultados = reader.GetString(0);

                }

                //convertimos los datos a json
                result = JsonConvert.DeserializeObject<Resultados>(resultados);


                //Cerramos la conexion
                conexion.Close();


                return result;


            }


        }
        
        //Leo la configuracion del juego del jugador actual
        public Datos leerConfiguracion(int id)
        {

            //Instruccion sql para leer la configuracion del juego actual
            string query = "SELECT (juego) FROM Juegos WHERE id=@id";


            //Abrir la conexion
            conexion.Open();

            //Ejecutamos la instruccion pasandole la conexion de la base de datos
            SqlCommand command = new SqlCommand(query, conexion);

            //Limpiamos los parametros del sqlcomand
            command.Parameters.Clear();

            //Insertamos el id como parametro
            command.Parameters.AddWithValue("@id", id);

            //Guardamos la config en resultados
            using (SqlDataReader reader = command.ExecuteReader())
            {
                Datos result = new Datos();
                string resultados = "";

                while (reader.Read())
                {

                    resultados = reader.GetString(0);

                }


                //convertimos los datos a json
                result = JsonConvert.DeserializeObject<Datos>(resultados);


                //Cerramos la conexion
                conexion.Close();


                return result;


            }


        }
       
        //Compruebo el estado para saber si el juego esta terminado o no 
        public Boolean leerEstado(int id)
        {
            //Abrir la conexion
            conexion.Open();

            //Instruccion sql para leer el estado
            string query = "SELECT estado FROM Juegos WHERE id  = @id";

            //Ejecutamos la instruccion pasandole la conexion de la base de datos
            SqlCommand command = new SqlCommand(query, conexion);

            //Limpiamos los parametros del sqlcomand
            command.Parameters.Clear();

            //Insertamos el id como parametro
            command.Parameters.AddWithValue("@id", id);

            Boolean estado = false;

            //Guardamos en la variable estado los datos
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {

                    estado = reader.GetBoolean(0);

                }

            }


            //Cerrar la conexion
            conexion.Close();

            return estado;


        }

    }
}

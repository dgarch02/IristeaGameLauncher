using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoGameLauncher
{
    public partial class GameLauncher : Form
    {
        private Funciones_BBDD bbdd;

        public GameLauncher()
        {
            InitializeComponent();
            bbdd = new Funciones_BBDD();


        }

        //Antes de cargar el Launcher
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Metodo que trata el scroll del numero de estimulos
        private void trackBarNumeroEstimulos_Scroll_1(object sender, EventArgs e)
        {
            // Display the trackbar value in the text box.
            textBoxNumEstimulos.Text = "" + trackBarNumeroEstimulos.Value;

        }

        //Metodo que trata el scroll del tamaño de los estimulos
        private void trackBarTamañoEstimulos_Scroll_1(object sender, EventArgs e)
        {
            // Display the trackbar value in the text box.
            textBoxTamEstimulos.Text = "" + trackBarTamañoEstimulos.Value;
        }

        //Metodo que trata el scroll del tamaño de letra
        private void trackBarTamañoLetra_Scroll_1(object sender, EventArgs e)
        {
            // Display the trackbar value in the text box.
            textBoxTamLetra.Text = "" + trackBarTamañoLetra.Value;
        }

        //Metodo que trata el scroll de la velocidad de rotación
        private void trackBarVelocidadRotación_Scroll_1(object sender, EventArgs e)
        {
            // Display the trackbar value in the text box.
            textBoxVelocidad.Text = "" + trackBarVelocidadRotación.Value;
        }

        //Metodo que trata la selección de color del fondo
        private void buttonColorFondo_Click(object sender, EventArgs e)
        {
            if (colorDialogFondo.ShowDialog() == DialogResult.OK)
            {
                //Pintamos el panel correspondiente para ser visual la selección
                panelColorFondo.BackColor = colorDialogFondo.Color;
            }
        }

        //Metodo que trata la selección del color del panel circular
        private void buttonColorPanel_Click_1(object sender, EventArgs e)
        {
            if (colorDialogPanel.ShowDialog() == DialogResult.OK)
            {
                //Pintamos el panel correspondiente para ser visual la selección
                panelColorPanel.BackColor = colorDialogPanel.Color;
            }

        }

        //Metodo que trata la selección del color del estimulo
        private void buttonColorEstimulo_Click_1(object sender, EventArgs e)
        {
            if (colorDialogEstimulo.ShowDialog() == DialogResult.OK)
            {
                //Pintamos el panel correspondiente para ser visual la selección
                panelColorEstimulo.BackColor = colorDialogEstimulo.Color;
            }
        }

        //Metodo que trata la selección del color de la letra
        private void buttonColorLetra_Click_1(object sender, EventArgs e)
        {
            if (colorDialogLetra.ShowDialog() == DialogResult.OK)
            {
                //Pintamos el panel correspondiente para ser visual la selección
                panelColorLetra.BackColor = colorDialogLetra.Color;
            }
        }

        //Obtengo el color del panel
        private Colores obtenerColorPanel()
        {
            string colorPanel_r = panelColorPanel.BackColor.R.ToString();
            string colorPanel_g = panelColorPanel.BackColor.G.ToString();
            string colorPanel_b = panelColorPanel.BackColor.B.ToString();
            
            return new Colores(colorPanel_r, colorPanel_g, colorPanel_b);
            
        }
        //Obtengo color del estimulo
        private Colores obtenerColorEstimulo()
        {

            string colorEstimulo_r = panelColorEstimulo.BackColor.R.ToString();
            string colorEstimulo_g = panelColorEstimulo.BackColor.G.ToString();
            string colorEstimulo_b = panelColorEstimulo.BackColor.B.ToString();
            return  new Colores(colorEstimulo_r, colorEstimulo_g, colorEstimulo_b);
        }
        //Obtener color de la letra
        private Colores obtenerColorLetra()
        {
            string colorLetra_r = panelColorLetra.BackColor.R.ToString();
            string colorLetra_g = panelColorLetra.BackColor.G.ToString();
            string colorLetra_b = panelColorLetra.BackColor.B.ToString();
            return new Colores(colorLetra_r, colorLetra_g, colorLetra_b);
        }
        //Obtener color fondo
        private Colores obtenerColorFondo()
        {
            string colorFondo_r = panelColorFondo.BackColor.R.ToString();
            string colorFondo_g = panelColorFondo.BackColor.G.ToString();
            string colorFondo_b = panelColorFondo.BackColor.B.ToString();
            return new Colores(colorFondo_r, colorFondo_g, colorFondo_b);
        }

        //Metodo que trata la acción del botón jugar
        private void botonJugar_Click_1(object sender, EventArgs e)
        {
            //Recojo los colores para comprobar errores
            Colores colorPanel = obtenerColorPanel();
            Colores colorEstimulo = obtenerColorEstimulo();
            Colores colorLetra = obtenerColorLetra();

            //Control de errores
            if (colorPanel == colorEstimulo)
            {
                MessageBox.Show("No se puede tener el mismo color de panel que de estimulo");
            }
            else if (colorLetra == colorEstimulo)
            {
                MessageBox.Show("No se puede tener el mismo color de la letra que de estimulo");
            }
            else
            {
                //Hasta el momento tengo recogido todos los datos ahora vamos a meterlos en un json
                Datos objetoJSON = crearJSON();

                //Inserto los datos del json en la base de datos y el estado
                //Almacenar el id de mi sesion de juego
                int id = bbdd.insertarDatosYObtenerID(objetoJSON);


                //Creo el proceso y sus ajustes
                Process proceso = new Process();
                proceso.StartInfo.FileName = "VideoGame.exe";
                proceso.StartInfo.UseShellExecute = true;
                proceso.StartInfo.WorkingDirectory = "C:\\Users\\dagar\\Desktop";
                proceso.StartInfo.Arguments = id.ToString();
                proceso.Start();

                //Esperamos a que termine el proceso
                proceso.WaitForExit();
                
                //Comprobamos que el juego no haya finalizado con el estado 1
                Boolean estado = bbdd.leerEstado(id);
                Boolean final = true;

                //Si el juego a terminado ya tendremos los resultados en la bbdd
                if (estado.Equals(final))
                {
                    //Ocultamos la ventana
                    this.Hide();

                    //Abrimos el form2
                    VideoGame ventana2 = new VideoGame(this,id);
                    ventana2.Show();

                }
                else
                {
                    MessageBox.Show("ERROR");
                }


                

            }
        }

  
        private void radioButtonAvanzado_CheckedChanged(object sender, EventArgs e)
        {
            trackBarTamañoLetra.Enabled = true;
            buttonColorLetra.Enabled = true;

        }

        private void radioButtonSimple_CheckedChanged(object sender, EventArgs e)
        {
            trackBarTamañoLetra.Enabled = false;
            buttonColorLetra.Enabled = false;
        }

        private Datos crearJSON()
        {
            //Recogemos los valores del Launcher, por defecto todos estan a 1
            int numEstimulos = trackBarNumeroEstimulos.Value;
            int tamEstimulos = trackBarTamañoEstimulos.Value;
            int tamLetra = trackBarTamañoLetra.Value;
            int velRotacion = trackBarVelocidadRotación.Value;

            //Leemos los colores escogidos, por defecto estan puestos unos y recogemos los valores en rgb
            Colores colorFondo = obtenerColorFondo();
            string colorFondoJuego = colorFondo.R + "." + colorFondo.G + "." + colorFondo.B;
            Colores colorPanel = obtenerColorPanel();
            string colorCirculo = colorPanel.R + "." + colorPanel.G + "." + colorPanel.B;
            Colores colorEstimulo = obtenerColorEstimulo();
            string colorEstimulos = colorEstimulo.R + "." + colorEstimulo.G + "." + colorEstimulo.B;
            Colores colorLetras = obtenerColorLetra();
            string colorNumeros = colorLetras.R + "." + colorLetras.G + "." + colorLetras.B;


            //Variables para saber el modo de juego

            string opcionJuego = "";

            //Comprobación del tipo de juego seleccionado
            if (radioButtonAvanzado.Checked)
            {
                
                opcionJuego = "B";
            }
            else
            {
                
                opcionJuego = "A";
            }

            //Creamos el JSON y metemos la infromacion
            Datos objetoJSON = new Datos()
            {
                velocidad = velRotacion,
                numeroEstimulos = numEstimulos,
                tamanyoLetra = tamLetra,
                tamanyoEstimulos = tamEstimulos,
                letra = opcionJuego,
                colorFondo = colorFondoJuego,
                colorCirculoExterior = colorCirculo,
                colorEstimulos = colorEstimulos,
                colorLetra = colorNumeros
            };

            return objetoJSON;
        }

    }
}

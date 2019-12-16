using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoGameLauncher
{
    public partial class VideoGame : Form
    {
        private int id = 0;

        public VideoGame()
        {

            InitializeComponent();
            recogerDatos();

        }

        public VideoGame(Form uno, int id)
        {
            InitializeComponent();
            ventana = uno;
            this.id = id;
            recogerDatos();
            
            
        }

        //Guardamos en ella el Form1 
        private Form ventana;

        private void recogerDatos()
        {
            Funciones_BBDD bbdd = new Funciones_BBDD();
            Resultados results = new Resultados();
            Datos configuracion = new Datos();

            results = bbdd.leerResultados(id);
            configuracion = bbdd.leerConfiguracion(id);

            //Comprobamos que los label no estan vacios y añadimos los resultados del json
            if (labelDuracionResultado != null)
            {
                labelDuracionResultado.Text += " " + results.tiempo;
            }
            if (labelMalos != null)
            {
                labelMalos.Text += " " + results.fallos;
            }
            if (labelTotalPrecision != null)
            {
                int suma = results.numeroClicks + results.fallos;
                labelTotalPrecision.Text += " " + suma.ToString() ;
            }

            //Calculamos los clicks buenos y rellenamos el label
            int buenos = results.numeroClicks ;
            if (labelBuenos != null)
            {
                labelBuenos.Text += " " + buenos.ToString();
            }

            //Calculamos el porcentaje de aciertos
            float bueno = (float)buenos;
            float totalClicks = (float)results.numeroClicks + results.fallos;

            double porcentaje = Math.Round( (bueno / totalClicks) * 100 , 2);

            
            if (labelPorcentaje != null)
            {
                labelPorcentaje.Text += " " + porcentaje.ToString() + "%";
            }


            //Introducimos todos los datos de la configuracion del usuario
            if (labelVelocidad != null)
            {
                labelVelocidad.Text += " " + configuracion.velocidad;
            }
            if (labelNumEstimulos != null)
            {
                labelNumEstimulos.Text += " " + configuracion.numeroEstimulos;
            }
            if (labelNivel != null)
            {
                if (configuracion.letra.Equals("A"))
                {
                    labelNivel.Text += " Simple";
                }
                else
                {
                    labelNivel.Text += " Avanzado";
                }
                
            }
            if (labelTamanyoLetra != null)
            {
                labelTamanyoLetra.Text += " " + configuracion.tamanyoLetra;
            }
            if (labelTamanyoEstimulos != null)
            {
                labelTamanyoEstimulos.Text += " " + configuracion.tamanyoEstimulos;
            }
            if (labelFecha != null)
            {
                labelFecha.Text += " " + DateTime.Today.ToShortDateString();
            }

          
        }

        //Evento para que al pulsar cerrar cerremos el form1
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            ventana.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

    }
}

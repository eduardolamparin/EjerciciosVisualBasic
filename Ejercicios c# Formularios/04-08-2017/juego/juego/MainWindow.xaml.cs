using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace juego
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Button [,] botones;
        private int numAciertos, numFallos;
        private const int alto = 4, ancho = 4;
        private int numero1, numero2;
        private int filanum, colnum;
        private DispatcherTimer tiempoJuego;
        private Image[,] imagenes;
        private Grid[,] ph;
        private TextBlock[,] numeroa;
        private System.Media.SoundPlayer sonido;

        public MainWindow()
        {
            sonido = new System.Media.SoundPlayer();
            sonido = new System.Media.SoundPlayer(juego.Properties.Resources.feel_good_x);
            sonido.Load();
            sonido.Play();
            tiempoJuego = new DispatcherTimer();
            tiempoJuego.Tick +=new EventHandler (segundosJuego);
            tiempoJuego .Interval = new TimeSpan (0,0,1);
            tiempoJuego .Start ();
            numero1 = -1;
            numero2 = -1;
            numAciertos = 0;
            numFallos = 0;
            InitializeComponent();

            ph = new Grid[alto, ancho];
            imagenes = new Image[alto, ancho];
            numeroa = new TextBlock[alto, ancho];
            botones = new Button[alto, ancho];
            Numeros num = new Numeros();
            for (int i = 0; i < alto; i++)
            {
                for (int j = 0; j < ancho; j++)
                {
                    botones[i, j] = new Button();
                    botones[i, j].Click += clickBoton;
                    int numero = num.obtenernumero();
                   
                    botones[i, j].Foreground = new SolidColorBrush(Colors .Transparent );
                    Grid.SetColumn(botones[i, j], i);
                    Grid.SetRow(botones[i, j], j);
                    Pantalladejuego.Children.Add(botones [i,j]);
                    ph[i, j] = new Grid();
                    numeroa[i, j] = new TextBlock();
                    numeroa[i, j].Text = numero.ToString();
                    numeroa[i, j].Visibility = Visibility.Collapsed;
                    botones[i, j].Content = ph[i, j];
                    imagenes[i, j] = new Image();
                    imagenes[i, j].Source = new BitmapImage(new Uri(num.conseguirImagenes(numero), UriKind.Relative));
                    ph[i, j].Children.Add(imagenes [i,j]);
                    imagenes [i, j].Visibility = Visibility.Collapsed;
                }

            }
        }


        private async   void clickBoton(object sender, RoutedEventArgs e)
        {
            //cambia de un tipo objet a un boton y cambiamos el color de la fuente;
            imagenes[Grid.GetColumn((Button)sender), Grid.GetRow((Button)sender)].Visibility = Visibility.Visible ;

            if (numero1 ==-1)
            {
                numero1 = int.Parse(numeroa [Grid .GetColumn ((Button)sender ),Grid .GetRow ((Button )sender )].Text .ToString ());
                colnum = Grid.GetColumn((Button)sender);
                filanum = Grid.GetRow((Button)sender);
            }
            else
            {
                numero2 = int.Parse(numeroa[Grid.GetColumn((Button)sender), Grid.GetRow((Button)sender)].Text.ToString());
                await Task.Delay(600);
                if (numero1 ==numero2 )
                {
                    numAciertos++;
                    aciertos.Text = numAciertos.ToString();
                     ((Button)sender).IsEnabled = false;

                     botones[colnum, filanum].IsEnabled = false;
                }
                else
                {
                    numFallos++;
                    fallidos.Text = numFallos.ToString();
                    imagenes[Grid.GetColumn((Button)sender), Grid.GetRow((Button)sender)].Visibility = Visibility.Collapsed;
                    imagenes[colnum, filanum].Visibility = Visibility.Collapsed;
                    ((Button)sender).IsEnabled = true;
                    botones[colnum , filanum ].IsEnabled = true;
            
                }
                numero1 = -1;
            }
            if (numAciertos ==8)
            {
                tiempoJuego.Stop();
                MessageBox.Show("Usted ha ganado");
            }
        }
        private int segundos = 0;
        private  void segundosJuego(object sender, EventArgs e)
        {
            tiempo.Text = segundos.ToString();
            segundos++;
        }
    }
}

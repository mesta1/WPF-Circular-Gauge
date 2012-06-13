using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
using System.ComponentModel;

namespace CircularGaugeDemoWPF
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        //Private variables
        DispatcherTimer timer;
        Game game1;
        Game game2;
        Game game3;
        Game game4;

        public Window1()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(Window1_Loaded);
        }

        void Window1_Loaded(object sender, RoutedEventArgs e)
        {
            //Set the current value of the gauges
            game1 = new Game(0);
            this.myGauge1.DataContext = game1;
            game2 = new Game(0);
            this.myGauge2.DataContext = game2;
            game3 = new Game(0);
            this.myGauge3.DataContext = game3;
            game4 = new Game(0);
            this.myGauge4.DataContext = game4;

            //Start the timer
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(2500);
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            //Update random scores
            Random r = new Random();
            game1.Score = r.Next(0, 1000);
            double val = r.Next(1, 10);
            game2.Score = val / 10;
            game3.Score = r.Next(-50, 50);
            game4.Score = r.Next(0, 1000);


        }

    }

    /// <summary>
    /// Helper class to simulate a game
    /// </summary>
    public class Game : INotifyPropertyChanged
    {
        private double score;

        public double Score
        {
            get { return score; }
            set
            {
                score = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Score"));
                }
            }
        }


        public Game(double scr)
        {
            this.Score = scr;
        }


        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}

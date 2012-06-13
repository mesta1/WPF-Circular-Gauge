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
using System.ComponentModel;

namespace TestThis
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private double score = 0;
        public double Score { get { return score; } set { score = value; this.OnPropertyChanged("Score"); } }

        private double _max;
        public double Max
        {
            get { return _max; }
            set { _max = value; this.OnPropertyChanged("Max"); }
        }
        
        public MainWindow()
        {
            Max = 1000;
            InitializeComponent();
            myGauge1.DataContext = this;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Score += 10;
        }       

        #region INotifyPropertyChanged members

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}

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

namespace FormApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string cond = "scrieti un program in care schimbati anotimpurile in consecutivitate si le printati";

        private enum Anotimpuri
        {
            Primavara,
            Vara,
            Toamna,
            Iarna
        }
        private Anotimpuri animCurent;

        public MainWindow()
        {
            InitializeComponent();
            ArataConditia();
        }

        private void ArataConditia()
        {
            Conditia.Text = cond;
        }

        private void Rezultat_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i <= 3; i++)
            {
                if (i == 0) { animCurent = Anotimpuri.Primavara; }
                else if (i == 1) { animCurent = Anotimpuri.Vara; }
                else if (i == 2) { animCurent = Anotimpuri.Toamna; }
                else             { animCurent = Anotimpuri.Iarna; }
                RezultatText.Text += "\n" + animCurent.ToString();
            }

        }
    }
}

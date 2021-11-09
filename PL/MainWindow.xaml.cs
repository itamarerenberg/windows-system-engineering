using BE;
using BL;
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

namespace PL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private FlowersFinder flowersFinder { get; set; }
        public MainWindow()
        {
            flowersFinder = new FlowersFinder();
            InitializeComponent();
        }

        private void srcButton_Click(object sender, RoutedEventArgs e)
        {
            string srcStr = srcTBox.Text;
            List<Flower> flowers = flowersFinder.Search(srcStr);
            lvData.ItemsSource =  flowers != null? flowers : new List<Flower>();
        }
    }
}

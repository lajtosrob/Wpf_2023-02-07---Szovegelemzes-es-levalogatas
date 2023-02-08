using System;
using System.Collections.Generic;
using System.IO;
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

namespace Wpf_2023_02_07___Szövegelemzés_és_leválogatás
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] janosVitezSorok;
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void btnBetolt_Click(object sender, RoutedEventArgs e)
        {
            janosVitezSorok = File.ReadAllLines("JánosVitéz.txt");


            for (int sorokIndex = 0; sorokIndex < janosVitezSorok.Length; sorokIndex++)
            {
                lbVerssorok.Items.Add(janosVitezSorok[sorokIndex]);
            }
        }

        private void btnLevalogat_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in lbVerssorok.Items)
            {
                if (Convert.ToString(item).Contains(txtKerSzovResz.Text))
                {

                    lbLevalogatott.Items.Add(item);

                }
            }
        }
    }
}

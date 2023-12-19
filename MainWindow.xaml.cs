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
using System.Data.SQLite;

namespace MetersData
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string textWaterCold = WaterCold.Text;
            if(textWaterCold !="")
            {
                MessageBox.Show(textWaterCold);
            }

            string textWaterHot = WaterHot.Text;
            if( textWaterHot !="")
            {
                MessageBox.Show(textWaterHot);
            }

            string textElectricity = Electricity.Text;
            if(textElectricity !="")
            {
                MessageBox.Show(textElectricity);
            }

            string textGas = Gas.Text;
            if(textGas !="")
            {
                MessageBox.Show(textGas);
            }
        }
    }
}
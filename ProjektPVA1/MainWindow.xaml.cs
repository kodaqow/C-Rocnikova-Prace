using System.Collections.ObjectModel;
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

namespace ProjektPVA1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Produkt> Sklad = new ObservableCollection<Produkt>();

        public MainWindow()
        {
            InitializeComponent();

            Sklad.Add(new Produkt("Brumík", 60, 50));
            Sklad.Add(new Produkt("Kofola", 45, 40));
            Sklad.Add(new Produkt("Vinea", 35, 50));
            Sklad.Add(new Produkt("Kubík", 45, 40));

            dgSklad.ItemsSource = Sklad;
        }
    }
}
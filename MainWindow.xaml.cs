using System.IO;
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

namespace _2025_04_14_orai
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<Hajok> hajok = new();

        public MainWindow()
        {
            InitializeComponent();
            string allomany = "adatok.txt";
            FajlBeolvasas(allomany);
            dgAdatKijelzes.ItemsSource = hajok;
            ComboFill();

        }

        public static void FajlBeolvasas(string allomany)
        {
            try
            {
                using(StreamReader sr = new StreamReader(allomany))
                {
                    sr.ReadLine();

                    while (!sr.EndOfStream)
                    {
                        string sor = sr.ReadLine();
                        hajok.Add(new(sor));
                    }
                }
                MessageBox.Show("A fájl beolvasása sikeres volt.");

            } catch (Exception ex)
            {
                MessageBox.Show("Hiba történt a fájl beolvasásakor: " + ex.Message);
            }
        }

        void ComboFill()
        {
            HashSet<string> orszagok = hajok.Select(x => x.Orszag).ToHashSet();

            cbxOrszag.Items.Add("Összes");
            cbxOrszag.SelectedItem = "Összes";
            foreach (string orszag in orszagok)
            {
                cbxOrszag.Items.Add(orszag);
            }
            
        }

        void Szures(object sender, RoutedEventArgs e)
        {

        }
    }
}
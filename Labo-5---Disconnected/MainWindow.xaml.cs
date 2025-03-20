using Microsoft.Win32;
using MonsterClassLibrary.DataAccess;
using System.Data;
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

namespace Labo_5___Disconnected
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // TODO: DataTable koppelen aan DataGrid
        }

        private void ClearMonsters_Click(object sender, RoutedEventArgs e)
        {
            // TODO: alle monsters verwijderen
        }

        private void ImportFromXml_Click(object sender, RoutedEventArgs e)
        {
            // TODO: laat de gebruiker een bestand selecteren en
            // importeer de gegevens met behulp van MonsterData
        }

        private void ExportToXml_Click(object sender, RoutedEventArgs e)
        {
            // TODO: laat de gebruiker een bestand selecteren en 
            // exporteer de gegevens met behulp van MonsterData
        }

        private void GenerateMonster_Click(object sender, RoutedEventArgs e)
        {
            MonsterData.AddRandomMonster();
        }

        private void MonsterDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // 5. Bonus:
            // - Voeg afbeeldingen toe in het project voor al de monsters.
            // - Verander de source van de afbeelding op basis van de geselecteerde DataRowView
        }
    }
}
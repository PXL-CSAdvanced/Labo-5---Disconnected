using Microsoft.Win32;
using MonsterClassLibrary.DataAccess;
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
            MonsterDataGrid.ItemsSource = MonsterData.MonsterDataTable.DefaultView;
        }

        private void ClearMonsters_Click(object sender, RoutedEventArgs e)
        {
            MonsterData.ClearAllMonsters();
        }

        private void ImportFromXml_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == true)
            {
                MonsterData.ImportFromXML(ofd.FileName);
            }
        }

        private void ExportToXml_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == true)
            {
                MonsterData.ExportToXML(sfd.FileName);
            }
        }

        private void GenerateMonster_Click(object sender, RoutedEventArgs e)
        {
            MonsterData.AddRandomMonster();
        }
    }
}
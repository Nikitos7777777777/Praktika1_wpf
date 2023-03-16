using System;
using System.Collections.Generic;
using System.Data;
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
using PRAKTIKA_1WPF.megezDataSetTableAdapters;

namespace PRAKTIKA_1WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ProdyktiTableAdapter Prodykti = new ProdyktiTableAdapter();
        ProizvoditelTableAdapter p = new ProizvoditelTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            ProdyktiDataGrid.ItemsSource = Prodykti.GetData();
            ProdyktiComboBox.ItemsSource = p.GetData();
            ProdyktiComboBox.DisplayMemberPath = "Manufacturer_Name";
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object cell = (ProdyktiComboBox.SelectedItem as DataRowView).Row[1];
            MessageBox.Show(cell.ToString());
        }
    }
}

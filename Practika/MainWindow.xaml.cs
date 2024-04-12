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
using Practika.Practika1DataSetTableAdapters;

namespace Practika
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DistrictTableAdapter district = new DistrictTableAdapter();
        private Practika1Entities context = new Practika1Entities();
        public MainWindow()
        {
            InitializeComponent();
            DistrictGrid.ItemsSource = district.GetData();
            housesGrid.ItemsSource = context.houses.ToList();
        }
    }
}

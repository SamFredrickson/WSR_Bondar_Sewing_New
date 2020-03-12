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
using System.Windows.Shapes;

namespace WSR_New_Sewing.View.Stockman
{
    /// <summary>
    /// Логика взаимодействия для StockManMiddleForm.xaml
    /// </summary>
    public partial class StockManMiddleForm : Window
    {
        public StockManMiddleForm()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new StockmanRolls().Show();
            Close();
        }
    }
}

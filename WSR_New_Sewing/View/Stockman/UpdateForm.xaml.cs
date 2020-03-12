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
using WSR_New_Sewing.Model;
using WSR_New_Sewing.ViewModel;

namespace WSR_New_Sewing.View.Stockman
{
    /// <summary>
    /// Логика взаимодействия для UpdateForm.xaml
    /// </summary>
    public partial class UpdateForm : Window
    {
        StockmanViewModel context;
        StockmanModel stockman;

        public UpdateForm(StockmanModel model)
        {
            InitializeComponent();
            DataContext = context = new StockmanViewModel();
            stockman = model;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new StockmanRolls().Show();
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            color.Text = stockman.Цвет;
            material.Text = stockman.Материал;
            Width.Text = stockman.Ширина.ToString();
            length.Text = stockman.Длина.ToString();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            context.Update(new StockmanModel {
                
                Ид = stockman.Ид,
                Цвет = color.Text,
                Материал = material.Text,
                Ширина = Convert.ToDecimal(Width.Text),
                Длина = Convert.ToDecimal(length.Text),
            });

            new StockmanRolls().Show();
            Close();
        }
    }
}

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
using WSR_New_Sewing.Core.Classes;
using WSR_New_Sewing.Core.Entity;
using WSR_New_Sewing.Model;
using WSR_New_Sewing.View;

namespace WSR_New_Sewing
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var ctx = new EntityContext())
                {
                    var user = ctx.User.FirstOrDefault(u => u.Login == login.Text && u.Password == password.Text);
                    if (user == null)
                        throw new Exception("Неверный логин или пароль!");

                    UserModelSingleton.Instance().GetModel(user).OpenWindow();
                    Close();
                }
            }
            catch (Exception ex)
            {

                DialogService.ShowError(ex.Message, "Ошибка!");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new Registration().Show();
            Close();
        }
    }
}

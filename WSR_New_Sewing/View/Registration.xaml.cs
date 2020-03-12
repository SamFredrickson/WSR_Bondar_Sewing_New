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
using WSR_New_Sewing.Core.Classes;
using WSR_New_Sewing.Core.Entity;

namespace WSR_New_Sewing.View
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
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
            try
            {
                using (var ctx = new EntityContext())
                {
                    if(RegValidation.Validate(firstname.Text, secondname.Text, login.Text, password.Text) == true)
                    {
                        var user = new User
                        {
                            RoleId = 1,
                            FirstName = firstname.Text,
                            SecondName = secondname.Text,
                            LastName = lastname.Text,
                            Login = login.Text,
                            Password = password.Text
                        };

                        ctx.User.Add(user);
                        ctx.SaveChanges();
                        DialogService.ShowSuccess("Вы были зарегистрированы!", "Успех!");
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

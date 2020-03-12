using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WSR_New_Sewing.Core.Classes
{
    class DialogService
    {
        public static void ShowError(string msg, string capt)
        {
            MessageBox.Show(msg, capt, MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public static void ShowSuccess(string msg, string capt)
        {
            MessageBox.Show(msg, capt, MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}

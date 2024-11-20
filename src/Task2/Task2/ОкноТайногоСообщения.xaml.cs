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

namespace МногооконноеПриложение
{
    public partial class ОкноТайногоСообщения : Window
    {
        private const string СекретныйПароль = "котакбас123";
        private const string СекретноеСообщение = "Секретное сообщение!";

        public ОкноТайногоСообщения() { InitializeComponent(); }

        private void ПроверитьПароль_Click(object sender, RoutedEventArgs e)
        {
            string пароль = ПарольBox.Password;
            if (пароль == СекретныйПароль)
            {
                РезультатLabel.Content = СекретноеСообщение;
            }
            else
            {
                РезультатLabel.Content = "Неверный пароль. Попробуйте еще раз.";
            }
        }
    }
}
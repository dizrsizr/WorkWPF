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
    public partial class ОкноПроверкиДиапазона : Window
    {
        public ОкноПроверкиДиапазона() { InitializeComponent(); }

        private void Проверить_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(ЧислоTextBox.Text, out int число) && число >= 0 && число <= 100)
            {
                string результат = ПроверитьДиапазон(число);
                РезультатLabel.Content = результат;
            }
            else
            {
                РезультатLabel.Content = "Некорректный ввод числа.";
            }
        }

        private string ПроверитьДиапазон(int число)
        {
            if (число >= 0 && число <= 14) return "Число в диапазоне [0-14]";
            if (число >= 15 && число <= 35) return "Число в диапазоне [15-35]";
            if (число >= 36 && число <= 50) return "Число в диапазоне [36-50]";
            if (число >= 51 && число <= 100) return "Число в диапазоне [51-100]";
            return "Число не попадает ни в один диапазон.";
        }
    }
}
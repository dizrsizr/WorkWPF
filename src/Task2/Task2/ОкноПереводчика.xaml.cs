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
    public partial class ОкноПереводчика : Window
    {
        private readonly Dictionary<string, string> словарьПогоды = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            {"солнечно", "sunny"},
            {"облачно", "cloudy"},
            {"дождь", "rain"},
            {"снег", "snow"},
            {"ветер", "wind"},
            {"холодно", "cold"},
            {"тепло", "warm"},
            {"жарко", "hot"},
            {"пасмурно", "overcast"},
            {"туман", "fog"}
        };

        public ОкноПереводчика() { InitializeComponent(); }

        private void Перевести_Click(object sender, RoutedEventArgs e)
        {
            string слово = СловоTextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(слово))
            {
                РезультатLabel.Content = "Пожалуйста, введите слово.";
                return;
            }

            if (словарьПогоды.TryGetValue(слово, out string перевод))
            {
                РезультатLabel.Content = $"Перевод: {перевод}";
            }
            else
            {
                РезультатLabel.Content = "Такого слова нет в словаре.";
            }
        }
    }
}
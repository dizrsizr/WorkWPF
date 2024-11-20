using System;
using System.Windows;
using System.Windows.Controls;

namespace МногооконноеПриложение
{
    public partial class ОкноКалькулятора : Window
    {
        private double операнд1 = 10;
        private double операнд2 = 5;

        public ОкноКалькулятора() { InitializeComponent(); }

        private void ВычислитьButton_Click(object sender, RoutedEventArgs e)
        {
            string операция = ОператорTextBox.Text.Trim();

        }
    }
}
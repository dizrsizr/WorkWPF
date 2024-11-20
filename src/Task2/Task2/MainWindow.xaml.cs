using System.Windows;

namespace МногооконноеПриложение
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenTranslator_Click(object sender, RoutedEventArgs e) => new ОкноПереводчика().ShowDialog();
        private void OpenCalculator_Click(object sender, RoutedEventArgs e) => new ОкноКалькулятора().ShowDialog();
        private void OpenRangeCheck_Click(object sender, RoutedEventArgs e) => new ОкноПроверкиДиапазона().ShowDialog();
        private void OpenSecretMessage_Click(object sender, RoutedEventArgs e) => new ОкноТайногоСообщения().ShowDialog();
    }
}
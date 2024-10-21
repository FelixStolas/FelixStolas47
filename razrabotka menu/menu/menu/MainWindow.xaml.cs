using System.Windows;
using System.Windows.Media;

namespace WpfApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChangeColor_Click(object sender, RoutedEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.Black);
            StatusBarText.Text = "Цвет фона изменен";
        }

        private void DeveloperInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Бабаянц Феликс; " +
                "Версия: 1.0; " +
                "Разработчик: Музыкант", "О разработчике");
            StatusBarText.Text = "Информация о разработчике";
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ShowStatusBarMessage(object sender, RoutedEventArgs e)
        {
            if (sender is FrameworkElement element)
            {
                StatusBarText.Text = element.ToolTip.ToString();
            }
        }

        private void ClearStatusBarMessage(object sender, RoutedEventArgs e)
        {
            StatusBarText.Text = "Готово";
        }
    }
}


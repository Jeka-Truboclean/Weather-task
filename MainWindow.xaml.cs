using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Weather_task
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new WeatherViewModel();
        }
    }
    public class WeatherInfo
    {
        public string City { get; set; }
        public double Temperature { get; set; }
        public string Description { get; set; }
    }
    public class WeatherService
    {
        public WeatherInfo GetWeather(string city)
        {
            // Для демонстрации используем фиктивные данные
            var random = new Random();
            return new WeatherInfo
            {
                City = city,
                Temperature = random.Next(-10, 30),
                Description = "Ясно"
            };
        }
    }

}
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Weather_task;

public class WeatherViewModel : INotifyPropertyChanged
{
    private readonly WeatherService weatherService;
    private string selectedCity;
    private WeatherInfo weatherInfo;

    public WeatherViewModel()
    {
        weatherService = new WeatherService();
        Cities = new List<string> { "Moscow", "London", "New York", "Tokyo", "Paris" };
        SelectedCity = Cities[0];
        UpdateWeather();
    }

    public List<string> Cities { get; }

    public string SelectedCity
    {
        get => selectedCity;
        set
        {
            selectedCity = value;
            OnPropertyChanged();
            UpdateWeather();
        }
    }

    public WeatherInfo WeatherInfo
    {
        get => weatherInfo;
        private set
        {
            weatherInfo = value;
            OnPropertyChanged();
        }
    }

    private void UpdateWeather()
    {
        WeatherInfo = weatherService.GetWeather(SelectedCity);
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}

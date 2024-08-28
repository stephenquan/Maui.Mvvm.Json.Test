using System.Collections.ObjectModel;
using System.Text.Json;

namespace Maui.Mvvm.Json.Test;

public partial class MainPage : ContentPage
{
    public ObservableCollection<Person> People { get; } = new();

    public MainPage()
    {
        InitializeComponent();
    }

    public void LoadFromJson(string json)
    {
        People.Clear();

        List<Person>? people = JsonSerializer.Deserialize<List<Person>>(json);
        if (people == null)
        {
            return;
        }

        foreach (Person person in people)
        {
            People.Add(person);
        }
    }

    private void OnFlintstones(object sender, EventArgs e)
    {
        LoadFromJson("""
            [
                { "f": "Fred", "n": "Flintstone" },
                { "f": "Wilma", "n": "Flintstone" },
                { "f": "Pebbles", "n": "Flintstone" }
            ]
""");
    }

    private void OnBluey(object sender, EventArgs e)
    {
        LoadFromJson("""
            [
                { "f": "Bandit", "n": "Heeler" },
                { "f": "Chilli", "n": "Heeler" },
                { "f": "Bluey", "n": "Heeler" },
                { "f": "Bingo", "n": "Heeler" }
            ]
""");
    }

}

using CommunityToolkit.Mvvm.ComponentModel;
using System.Text.Json.Serialization;

namespace Maui.Mvvm.Json.Test;

public partial class Person : ObservableObject
{
    [ObservableProperty]
    [property: JsonPropertyName("f")]
    [NotifyPropertyChangedFor(nameof(FullName))]
    string firstName = string.Empty;

    [ObservableProperty]
    [property: JsonPropertyName("n")]
    [NotifyPropertyChangedFor(nameof(FullName))]
    string lastName = string.Empty;

    public string FullName => $"{FirstName} {LastName}";
}

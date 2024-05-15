
using VehicleAppBCA.Model;
using VehicleAppBCA.Services;

namespace VehicleAppBCA.Views;

public partial class VehiclesPage : ContentPage
{
    //public List<Vehicle> Vehicles { get; private set; } = new List<Vehicle>();
    private VehicleService vehicleService;

    public VehiclesPage()
    {
        InitializeComponent();
        this.vehicleService = VehicleService.Build();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        var list = this.vehicleService.GetVehicles();
        ListVehicles.ItemsSource = list;
    }

    public async void OnItemSelectedChanged(object sender, SelectedItemChangedEventArgs e)
    {
        var id = ((Vehicle)ListVehicles.SelectedItem).id;
        ListVehicles.SelectedItem = null;
        await Shell.Current.GoToAsync($"{nameof(VehiclePage)}?Id={id}");
    }
    public async void OnButtonCreate(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"{nameof(VehiclePage)}");
    }

    public void OnTextChanged(object sender, EventArgs e)
    {
        SearchBar searchBar = (SearchBar)sender;
        DisplayAlert("", searchBar.Text, "Done");
        //searchResults.ItemsSource = DataService.GetSearchResults(searchBar.Text);
    }
}
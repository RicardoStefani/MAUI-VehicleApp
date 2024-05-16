
using System.Collections.ObjectModel;
using VehicleAppBCA.Model;
using VehicleAppBCA.Services;

namespace VehicleAppBCA.Views;

public partial class VehiclesPage : ContentPage
{
    public ObservableCollection<Vehicle> Vehicles { get; set; } = new ObservableCollection<Vehicle>();
    private VehicleService vehicleService;

    public VehiclesPage()
    {
        InitializeComponent();
        this.vehicleService = VehicleService.Build();
        ListVehicles.ItemsSource = this.Vehicles;
        
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        var list = this.vehicleService.GetVehicles();
        this.Vehicles.Clear();
        foreach(var vehicle in list)
        {
            this.Vehicles.Add(vehicle);
        }

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

    void OnFavouriteCheckBoxhanged(object sender, CheckedChangedEventArgs e)
    {
        var checkBox = (CheckBox)sender;
        var vehicle = (Vehicle)checkBox.BindingContext;
        this.vehicleService.SetFavourite(vehicle.id, e.Value);
    }
}
namespace MauiAppHotel.Views;

public partial class Suites : ContentPage
{
	public Suites()
	{
		InitializeComponent();

		App PropriedadesApp = (App)Application.Current;

		cv_suites.ItemsSource = PropriedadesApp.lista_quartos;
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		Navigation.PopAsync();
	}
}

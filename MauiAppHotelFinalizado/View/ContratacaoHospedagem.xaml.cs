using MauiAppHotelFinalizado.Models;

namespace MauiAppHotelFinalizado.View;

public partial class ContratacaoHospedagem : ContentPage
{
	App PropriedadesApp;

	public ContratacaoHospedagem()
	{
		InitializeComponent();

		PropriedadesApp = (App)Application.Current;

		pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;
		dtpck_checkin.MinimumDate = DateTime.Now;
		dtpck_checkin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

		dtpck_checkout.MinimumDate = dtpck_checkin.Date.AddDays(1);
		dtpck_checkout.MaximumDate = dtpck_checkout.Date.AddMonths(6);
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Hospedagem h = new Hospedagem
			{
				QuartoSelecionado = (Quarto)pck_quarto.SelectedItem,
				QuantidadeAdultos = Convert.ToInt32(stp_adultos.Value),
				QuantidadeCriancas = Convert.ToInt32(stp_criancas.Value),
				DataCheckin = dtpck_checkin.Date,
				DataCheckout = dtpck_checkout.Date,
			};


			await Navigation.PushAsync(new HospedagemContratada()
			{
				BindingContext = h
			});

		}
		catch (Exception ex) 
		{

			await DisplayAlert("Ops", ex.Message, "Fechar");
		
		}
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
		try
		{
			Navigation.PushAsync(new Sobre());
		}
		catch (Exception ex)
		{
			DisplayAlert("Ops", ex.Message, "Fechar");
		}
    }

    private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
		DatePicker elemento = sender as DatePicker;

		DateTime data_selecionada_checkin = elemento.Date;
		dtpck_checkout.MinimumDate = data_selecionada_checkin.AddDays(1);
		dtpck_checkout.MaximumDate = data_selecionada_checkin.AddMonths(6);
    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Segredo());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "Fechar");
        }
    }
}
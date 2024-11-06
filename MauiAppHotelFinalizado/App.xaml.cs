using MauiAppHotelFinalizado.Models;

namespace MauiAppHotelFinalizado
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto()
            {
                Descricao = "Suite Super Luxo",
                valorDiariaAdulto = 110.0,
                valorDiariaCrianca = 55.0
            },
            new Quarto()
            {
                Descricao = "Suite Luxo",
                valorDiariaAdulto = 100.0,
                valorDiariaCrianca = 50.0
            },
            new Quarto()
            {
                Descricao = "Suite Single",
                valorDiariaAdulto = 50.0,
                valorDiariaCrianca = 25.0
            },
            new Quarto()
            {
                Descricao = "Suite Pobre",
                valorDiariaAdulto = 25.0,
                valorDiariaCrianca = 12.5
            }
        };
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new View.ContratacaoHospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);
                
            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }
}

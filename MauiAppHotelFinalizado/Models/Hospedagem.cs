namespace MauiAppHotelFinalizado.Models
{
    public class Hospedagem
    {
        public Quarto QuartoSelecionado { get; set; }
        public int QuantidadeAdultos { get; set; }
        public int QuantidadeCriancas { get; set;}
        public DateTime DataCheckin {  get; set; }
        public DateTime DataCheckout { get; set; }
        public int Estadia
        {
            get => DataCheckout.Subtract(DataCheckin).Days;
        }
        public double ValorTotal
        {
            get
            {
                double valor_adultos = QuantidadeAdultos * QuartoSelecionado.valorDiariaAdulto;
                double valor_criancas = QuantidadeCriancas * QuartoSelecionado.valorDiariaCrianca;

                double total = (valor_adultos + valor_criancas) * Estadia;

                return total;
            }
        }//Fim public valor total
    }
}

namespace EletrodomesticosAppWeb.Models;


public class Eletrodomestico
{
    public int EletrodomesticoId { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public double Preco {  get; set; }
    public string ImagemUri { get; set; }
    public bool FreteGratis { get; set; }
    public DateTime DataCadastro { get; set;}

}

namespace EletrodomesticosAppWeb.Models;

public class Marca
{
    public int MarcaId { get; set; }
    public string Descricao { get; set; }
    public ICollection<Eletrodomestico> Eletrodomesticos { get; set; }
}

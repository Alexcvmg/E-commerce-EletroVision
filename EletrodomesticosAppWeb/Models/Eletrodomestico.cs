using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EletrodomesticosAppWeb.Models;


public class Eletrodomestico
{
    public int EletrodomesticoId { get; set; }
    public string Nome { get; set; }
    public string NomeSlug => Nome.ToLower().Replace(" ", "-");

    public string Descricao { get; set; }

    [DisplayName(displayName:"Preço")]
    [DataType(DataType.Currency)]
    public double Preco {  get; set; }

    public string ImagemUri { get; set; }

    [DisplayName(displayName: "Frete Grátis:")]
    public bool FreteGratis { get; set; }
    public string FreteGratisFormatado => FreteGratis ? "Sim" : "Não";

    [DisplayName(displayName: "Disponível em:")]
    [DisplayFormat(DataFormatString ="{0:MMMM \\de yyyy}")]
    public DateTime DataCadastro { get; set;}

}

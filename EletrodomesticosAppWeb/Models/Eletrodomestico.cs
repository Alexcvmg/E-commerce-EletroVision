using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EletrodomesticosAppWeb.Models;

[Table("TBL_Eletrodomestico")]
public class Eletrodomestico
{
    public int EletrodomesticoId { get; set; }
    [Required(ErrorMessage = "Campo Obrigatório")]
    [StringLength(50, MinimumLength = 10, ErrorMessage ="Campo deve ter de 10 a 50 caracteres")]
    public string Nome { get; set; }
    public string NomeSlug => Nome.ToLower().Replace(" ", "-");

    public string Descricao { get; set; }
    [Required(ErrorMessage ="Campo Obrigatório")]
    [DisplayName(displayName:"Preço")]
    [DataType(DataType.Currency)]
    public double Preco {  get; set; }

    [Required(ErrorMessage = "Campo Obrigatório")]
    public string ImagemUri { get; set; }

    [DisplayName(displayName: "Frete Grátis:")]
    public bool FreteGratis { get; set; }
    public string FreteGratisFormatado => FreteGratis ? "Sim" : "Não";

    [Required(ErrorMessage = "Campo Obrigatório")]
    [DisplayName(displayName: "Disponível em:")]
    [DisplayFormat(DataFormatString ="{0:MMMM \\de yyyy}")]
    public DateTime DataCadastro { get; set;}

    [DisplayName(displayName: "Marca")]
    public int? MarcaId { get; set; }

}

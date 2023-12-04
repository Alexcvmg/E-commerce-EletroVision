using EletrodomesticosAppWeb.Models;

namespace EletrodomesticosAppWeb.Servico;

public interface IEletrodomesticoService
{
    public IList<Eletrodomestico> ObterTodos();

    public Eletrodomestico Obter(int id);

    public void Incluir(Eletrodomestico eletrodomestico);

    public void Alterar(Eletrodomestico eletrodomestico);

    void Excluir(int id);

    IList<Marca> ObterTodasMarcas();

    Marca ObterMarca(int id);
}

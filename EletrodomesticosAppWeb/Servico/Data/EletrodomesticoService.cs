using EletrodomesticosAppWeb.Data;
using EletrodomesticosAppWeb.Models;

namespace EletrodomesticosAppWeb.Servico.Data;

public class EletrodomesticoService : IEletrodomesticoService
{
    private EletrodomesticoDbContext _context;

    public EletrodomesticoService(EletrodomesticoDbContext context) 
    {  
        _context = context; 
    }


    public void Alterar(Eletrodomestico eletrodomestico)
    {
        var eletrodomesticoEncontrado = Obter(eletrodomestico.EletrodomesticoId);
        eletrodomesticoEncontrado.Nome = eletrodomestico.Nome;
        eletrodomesticoEncontrado.Descricao = eletrodomestico.Descricao;
        eletrodomesticoEncontrado.Preco = eletrodomestico.Preco;
        eletrodomesticoEncontrado.DataCadastro = eletrodomestico.DataCadastro;
        eletrodomesticoEncontrado.FreteGratis = eletrodomestico.FreteGratis;
        eletrodomesticoEncontrado.ImagemUri = eletrodomestico.ImagemUri;
        eletrodomesticoEncontrado.MarcaId = eletrodomestico.MarcaId;
        _context.SaveChanges();
    }

    public void Excluir(int id)
    {
        var eletrodomesticoEncontrado = Obter(id);
        _context.Eletrodomestico.Remove(eletrodomesticoEncontrado);
        _context.SaveChanges();
    }

    public void Incluir(Eletrodomestico eletrodomestico)
    {
        _context.Eletrodomestico.Add(eletrodomestico);
        _context.SaveChanges();
    }

    public Eletrodomestico Obter(int id)
    {
        return _context.Eletrodomestico.SingleOrDefault(item => item.EletrodomesticoId == id);
    }

    public IList<Eletrodomestico> ObterTodos()
    {
        return _context.Eletrodomestico.ToList();
    }

    public IList<Marca> ObterTodasMarcas()
        => _context.Marca.ToList();

    public Marca ObterMarca(int id)
         => _context.Marca.SingleOrDefault(item => item.MarcaId == id);
}

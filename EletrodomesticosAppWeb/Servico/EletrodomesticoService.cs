using EletrodomesticosAppWeb.Models;

namespace EletrodomesticosAppWeb.Servico
{
    public class EletrodomesticoService : IEletrodomesticoService
    {
        public EletrodomesticoService()
            => CarregarListaInicial();

        private IList<Eletrodomestico> _eletrodomestico;

        private void CarregarListaInicial() 
        {
            _eletrodomestico = new List<Eletrodomestico>()
        {
            new Eletrodomestico
            {
                EletrodomesticoId = 1,
                Nome = "Fogão 4 bocas",
                Descricao = "Eleve suas habilidades culinárias com nosso fogão potente e elegante. " +
                "Controle preciso da chama e design durável para resultados excepcionais em cada refeição.",
                ImagemUri = "/Imagens/Eletrodomesticos/Fogao.png",
                Preco = 500.50,
                FreteGratis = true,
                DataCadastro = DateTime.Now
            },
            new Eletrodomestico
            {
                EletrodomesticoId = 2,
                Nome = "Geladeira",
                Descricao = "Mantenha seus alimentos frescos com nossa geladeira de design moderno " +
                "e eficiente sistema de refrigeração. Organize com facilidade e adicione estilo à sua" +
                " cozinha.",
                ImagemUri = "/Imagens/Eletrodomesticos/Geladeira.png",
                Preco = 500.50,
                FreteGratis = true,
                DataCadastro = DateTime.Now
            },
            new Eletrodomestico
            {
                EletrodomesticoId = 3,
                Nome = "Microondas",
                Descricao = "Simplifique sua rotina na cozinha com nosso microondas versátil. " +
                "Aquecimento rápido, descongelação uniforme e design intuitivo para refeições " +
                "deliciosas em minutos.",
                ImagemUri = "/Imagens/Eletrodomesticos/Microondas.png",
                Preco = 300.00,
                FreteGratis = true,
                DataCadastro = DateTime.Now
            }
        };
        }

        public IList<Eletrodomestico> ObterTodos()
            => _eletrodomestico; 
        
        public Eletrodomestico Obter(int id)
        {
            return ObterTodos().SingleOrDefault(item => item.EletrodomesticoId == id);
        }

        public void Incluir(Eletrodomestico eletrodomestico) 
        {
            var proximoId = _eletrodomestico.Max(item => item.EletrodomesticoId) + 1;
            eletrodomestico.EletrodomesticoId = proximoId;
            _eletrodomestico.Add(eletrodomestico);
        }

        public void Alterar(Eletrodomestico eletrodomestico) 
        {
            var eletrodomesticoEncontrado = _eletrodomestico.SingleOrDefault(item => item.EletrodomesticoId == eletrodomestico.EletrodomesticoId);
            eletrodomesticoEncontrado.FreteGratis = eletrodomestico.FreteGratis;
            eletrodomesticoEncontrado.Descricao = eletrodomestico.Descricao;
            eletrodomesticoEncontrado.Preco = eletrodomestico.Preco;
            eletrodomesticoEncontrado.DataCadastro = eletrodomestico.DataCadastro;
            eletrodomesticoEncontrado.ImagemUri = eletrodomestico.ImagemUri;
            eletrodomesticoEncontrado.Nome = eletrodomestico.Nome;
        }

        public void Excluir(int id) 
        {
            var eletrodomesticoEncontrado = Obter(id);
            _eletrodomestico.Remove(eletrodomesticoEncontrado);
        }
    }
}

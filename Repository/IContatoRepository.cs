using SiteEmMVC.Models;

namespace SiteEmMVC.Repository
{
    public interface IContatoRepository
    {
        List<ContatoModel> BuscarTodos();

        ContatoModel Adicionar(ContatoModel contato);
    }
}

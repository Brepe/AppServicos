using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppServices.Presentation;

namespace AppServices.Presentation
{
    public class ItemService
    {
        private static ObservableCollection<MasterPageItem> menuLista { get; set; }

        public static ObservableCollection<MasterPageItem> GetMenuItens()
        {
            menuLista = new ObservableCollection<MasterPageItem>();
            // Criando as paginas para navegação
            // Definimos o titulo para o item
            // o icone do lado esquerdo e a pagina que vamos abrir
            var pagina1 = new MasterPageItem() { Title = "Home", TargetType = typeof(HomePage) };
            var pagina2 = new MasterPageItem() { Title = "CadastroUsuário", TargetType = typeof(CadastroUser) };
            var pagina3 = new MasterPageItem() { Title = "CadastroPrestador", TargetType = typeof(CadastroPrestador) };
            // Adicionando items no menuLista
            menuLista.Add(pagina1);
            menuLista.Add(pagina2);
            menuLista.Add(pagina3);
            //retorna a lista de itens 
            return menuLista;
        }
    }
}

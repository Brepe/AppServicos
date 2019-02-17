using System.Collections.ObjectModel;
using AppServices.Presentation;

namespace AppServices.Presentation
{
    public class ContaService
    {
        private static ObservableCollection<Conta> contasLista { get; set; }

        public static ObservableCollection<Conta> GetContas()
        {
            contasLista = new ObservableCollection<Conta>();

            contasLista.Add(new Conta() { Id = 1, Nome = "Salário", Status="Ativa" });
            contasLista.Add(new Conta() { Id = 2, Nome = "Alimentação", Status = "Ativa" });
            contasLista.Add(new Conta() { Id = 3, Nome = "Transporte", Status = "Ativa" });
            contasLista.Add(new Conta() { Id = 4, Nome = "Educação" , Status = "Ativa" });
            contasLista.Add(new Conta() { Id = 5, Nome = "Lazer" , Status = "Inativa" });
            contasLista.Add(new Conta() { Id = 6, Nome = "Saúde" , Status = "Ativa" });
            contasLista.Add(new Conta() { Id = 7, Nome = "Moradia" , Status = "Ativa" });

            return contasLista;
        }
    }
}

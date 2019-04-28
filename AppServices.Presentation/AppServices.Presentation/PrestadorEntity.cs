namespace AppServices.Presentation
{
    public class PrestadorEntity
    {
        public int id_prestador { get; set; }
        public string nome { get; set; }
        public long cpf { get; set; }
        public long cnpj { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string senha { get; set; }
        public bool empresa { get; set; }
        public int qtd_garcons { get; set; }
        public int qtd_fritadeiras { get; set; }
        public int qtd_copeiros { get; set; }
        public double p_garcons { get; set; }
        public double p_fritadeiras { get; set; }
        public double p_copeiros { get; set; }
        public int status { get; set; }
        //public Regiao fk_regiao { get; set; }
        //public Financeiro fk_financeiro { get; set; }

    }
}

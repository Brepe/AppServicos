namespace AppServices.Presentation
{
    public class PrestadorEntity
    {
        public int id_prestador { get; set; }
        public string nome { get; set; }
        public int cpf { get; set; }
        public int cnpj { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string senha { get; set; }
        public bool empresa { get; set; }
        public int qtd_garcons { get; set; }
        public int qtd_fritadeiras { get; set; }
        public int qtd_copeiros { get; set; }
        public float p_garcons { get; set; }
        public float p_fritadeiras { get; set; }
        public float p_copeiros { get; set; }
        public int status { get; set; }
        //public Regiao fk_regiao { get; set; }
        //public Financeiro fk_financeiro { get; set; }

    }
}

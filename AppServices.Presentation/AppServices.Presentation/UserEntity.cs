namespace AppServices.Presentation
{
    public class UserEntity
    {
        public int id_user { get; set; }
        public string nome { get; set; }
        public int cpf { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string senha { get; set; }
        public int Status { get; set; }
        //public Regiao fk_regiao { get; set; }
        //public Financeiro fk_financeiro { get; set; }

    }
}

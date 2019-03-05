using System;

namespace AppServices.Presentation
{
    public class ServicoEntity
    {
        public int id_servico { get; set; }
        public float valor_total { get; set; }
        public float[] valores_individuais { get; set; }
        public float taxa { get; set; }
        public string tipo_pgt { get; set; }
        public int status { get; set; }
        public string endereco { get; set; }
        public DateTime data_hota { get; set; }
        public float duracao { get; set; }
        public string detalhes { get; set; }


}
}

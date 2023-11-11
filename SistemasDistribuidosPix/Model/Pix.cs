namespace SistemasDistribuidosPix.Model
{
    public class Pix
    {
        public string endToEndId { get; set; }
        public string txid { get; set; }
        public string valor { get; set; }
        public ComponentesValor componentesValor { get; set; }
        public string chave { get; set; }
        public DateTime horario { get; set; }
        public string infoPagador { get; set; }
        public Pagador pagador { get; set; }
    }
}

namespace EstudoFormUpload.API.Model
{
    public class Evento
    {
        public int EventoId { get; set; }
        public int Ano { get; set; }
        public int Trimestre { get; set; }
        public int CodigoIBGE { get; set; }
        public string Municipio { get; set; }
        public string ImagemURL { get; set; }
    }
}
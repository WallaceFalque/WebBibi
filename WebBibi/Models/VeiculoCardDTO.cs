namespace WebBibi.Models
{
    public class VeiculoCardDTO
    {
        public string ImagemUrl { get; set; } = string.Empty;
        public string Titulo { get; set; } = string.Empty;
        public string Versao { get; set; } = string.Empty;
        public string Cambio { get; set; } = string.Empty;
        public string Preco { get; set; } = string.Empty;
        public string Ano { get; set; } = string.Empty;
        public string Quilometragem { get; set; } = string.Empty;
        public string Localizacao { get; set; } = string.Empty;
    }

    public class Veiculo
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int Ano { get; set; }
        public decimal Preco { get; set; }
        public bool EhOferta { get; set; }
        public bool AceitaUsado { get; set; }
        public string ImagemUrl { get; set; }
        public string TipoDeVeiculo { get; set; }
    }

}

using System.Collections.Generic;

namespace SistemaVendas.Models{
    public class Veiculo
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Cor { get; set; }
        public float Valor { get; set; }
        public int Situacao { get; set; }

        public int MarcaId { get; set; }
        public Marca Marca { get; set; }

        public ICollection<Venda> Vendas { get; set; }
    }
}
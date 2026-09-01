using System;

namespace SistemaVendas.Models{
    public class Venda
    {
        public int Id { get; set; }
        public DateTime DataVenda { get; set; }
        public float ValorVenda { get; set; }
        
        public float ValorCusto { get; set; } 
        public string Vendedor { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public int VeiculoId { get; set; }
        public Veiculo Veiculo { get; set; }
    }
}
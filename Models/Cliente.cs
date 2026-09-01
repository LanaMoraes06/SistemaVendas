using System.Collections.Generic;

namespace SistemaVendas.Models{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Area { get; set; }
        public int Idade { get; set; }
        public float ValorHora { get; set; }

        public int CidadeId { get; set; }
        public Cidade Cidade { get; set; }

        public ICollection<Venda> Vendas { get; set; }
    }
}
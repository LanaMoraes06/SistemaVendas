using System.Collections.Generic;

namespace SistemaVendas.Models{
    public class Marca
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }

        public ICollection<Veiculo> Veiculos { get; set; }
    }
}
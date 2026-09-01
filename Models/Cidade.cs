using System.Collections.Generic;

namespace SistemaVendas.Models{
    public class Cidade
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Sigla { get; set; } 

    
        public ICollection<Cliente> Clientes { get; set; }
    }
}
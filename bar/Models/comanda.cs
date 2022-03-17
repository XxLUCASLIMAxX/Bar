using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace bar.Models
{
    public class comanda
    {
        [Key]
        public int codigo { get; set; }
        public string Name { get; set; }


        public double valor        {get;set; }

        public double setValor ()
        {
            foreach (var item in itens) { this.valor += item.valor;
                    
                    }

            return valor;
        }
        public List<item> itens { get; set; }

        


    }


}

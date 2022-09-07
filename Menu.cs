using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurante
{
    public class Menu
    {
       public int Sujo { get; set; }

        public int Servir { get; set; }

        public bool SairDoRestaurante()

        {
            if (Sujo == 0)
            {
                Console.WriteLine("Solite a limpeza do prato para finalizar");
                return false;
            }
            else
            {
                Console.WriteLine("Volte sempre!");
                return true;
            }
        }
        public bool LimparPrato()
        {
            if (Servir == 0)
            {
                Console.WriteLine("Antes de limpar o prato, faça o seu pedido");
                return false;
            }

            else
            {
                Console.WriteLine("Prato Limpo");
                return true;
            }
        }
        

    }

        
    
}


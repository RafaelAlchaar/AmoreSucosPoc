using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmoreSucos.Entities
{
    public static class SucoRepository
    {
        public static List<Suco> ObterLista()
        {
            return new List<Suco>
        {
            new Suco("Suco de Laranja", 20),
            new Suco("Suco de Morango", 12),
            new Suco("Suco de Abacaxi", 10),
            new Suco("Suco de Limão", 30),
            new Suco("Suco de Acerola", 10),
            new Suco("Suco de Manga", 15)
        };

        }
    }
}

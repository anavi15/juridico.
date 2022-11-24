using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juridico.models
{
    public class advogado
    {
        

        public string nome { get; set; }
        public string sobrenome { get; set; }
        public int idade { get; set; }
        public char sexo { get; set; }
        public Pais pais { get; set; }
        public List<advogado> getAdvogados()
        {
            return null;
        }
        public  List<advogado> getNomeCompleto(advogado adv)
        {
            return null;
        }
        public List<advogado> getAdvogadoPorID(int pcodigo)
        {
            return null;
        }
        public List<advogado> getAdvogadoporPais(int ppais)
        {
            return null;
        }












    }
}

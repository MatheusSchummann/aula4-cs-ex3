using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula4_cs_ex3
{
    public class Convert
    {
        public List<double> Logica1(List<double> ListaD) 
        {
            if (ListaD[0] >= ListaD[1] && ListaD[0] >= ListaD[2])
            {
                return ListaD;
            }
            else if (ListaD[1] >= ListaD[0] && ListaD[1] >= ListaD[2])
            {
                double aux;
                aux = ListaD[0];
                ListaD[0] = ListaD[1];
                ListaD[1] = aux;            
            }
            else
            {
                double aux1, aux2;
                aux1 = ListaD[0];
                aux2 = ListaD[1];
                ListaD[0] = ListaD[2];
                ListaD[1] = aux1;
                ListaD[2] = aux2;
            }

            return ListaD;
        }
        public int Logica2(List<double> ListaD) 
        {
            if (ListaD[0] * ListaD[0] == ListaD[1] * ListaD[1] + ListaD[2] * ListaD[2])
            {
                return 0;
            }
            else if (ListaD[0] * ListaD[0] > ListaD[1] * ListaD[1] + ListaD[2] * ListaD[2])
            {
                return 1;
            }
            else if (ListaD[0] * ListaD[0] < ListaD[1] * ListaD[1] + ListaD[2] * ListaD[2])
            {
                return 2;
            }
            return 3;
        }
    }
}

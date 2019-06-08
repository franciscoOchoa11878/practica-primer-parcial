using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Adoptador : Persona
    {
        private bool _Aprovado;
        
        public  bool Aprovado
        {
            get { return _Aprovado; }
            set { _Aprovado = value; }
        }

        public Adoptador(int pId, string pNombre, string pApellidos, int pEdad,bool pAprobado) : base(pId, pNombre, pApellidos, pEdad)
        {
            Aprovado = pAprobado;
        }
    }
}

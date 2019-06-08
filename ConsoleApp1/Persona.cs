using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Persona
    {
        private int _Id;
        private string _Nombre;
        private string _Apellidos;
        private int _Edad;
  
       

        public int Id
        {
            get { return _Id; }
            set { _Id = value;}
        }
        
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        public string Apellidos
        {
            get { return _Apellidos;}
            set { _Apellidos = value; }
        }
        public  int Edad
        {
            get { return _Edad; }
            set { _Edad = value; }
        }

       

        public Persona(int Pid, string Pnombre, string PApellidos, int PEdad)
        {
            Id = Pid;
            Nombre = Pnombre;
            Apellidos = PApellidos;
            Edad = PEdad;
        }
    }
}

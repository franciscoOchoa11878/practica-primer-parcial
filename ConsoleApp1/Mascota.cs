using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Mascota
    {
        private int _ID;
        private string _Nombre;
        private string _Raza;
        private int _Edad;


        public int Id
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        public string Raza
        {
            get { return _Raza; }
            set { _Raza = value; }
        }
        public int Edad
        {
            get { return _Edad; }
            set { _Edad = value; }
        }
        public Mascota(int Pid, string pNombre, string PRaza, int pedad)
        {
            Id = Pid;
            Nombre = pNombre;
            Raza = PRaza;
            Edad = pedad;
        }
    }
}


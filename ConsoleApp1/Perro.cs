using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Perro : Mascota
    {
        private double _peso;
        private string _cuidados;
        private string _AreaObligatoria;
        private double _altura;

        public double peso
        {
            get { return _peso;}
            set { _peso = value;}            
        }
        public string Cuidados
        {
            get { return _cuidados;}
            set { _cuidados = value;}
        }
        private string areaobligatoria
        {
            get { return _AreaObligatoria;}
            set { _AreaObligatoria = value;}
        }
        private double Altura
        {
            get { return _altura;}
            set { _altura = value;}
        }

        public Perro (int Pid,string pNombre, string PRaza, int pedad,double ppeso, double Paltura,string Pcuidados,string Pareaobligatoria) :base(Pid,pNombre,PRaza,pedad)
        {
            peso = ppeso;
            Cuidados = Pcuidados;
            Altura = Paltura;
            areaobligatoria = Pareaobligatoria;

        }
    
    }
}
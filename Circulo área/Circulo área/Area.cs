using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Circulo_área
{
    public class Area
    {
        public float pi = 3.1416f;
        public float resultado;
        //public Area(float Radio)
        //{
        //    radio = Radio;

        //}
        public float Areadelcirculo(float radio)
        {
            return resultado=radio * pi * pi;
        }
        
    }
}

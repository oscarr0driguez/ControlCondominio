using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCondominio
{
    class Propiedades
    {
        string numCasa;
        int dpiDueño;
        int mantenimiento;

        public string NumCasa { get => numCasa; set => numCasa = value; }
        public int DpiDueño { get => dpiDueño; set => dpiDueño = value; }
        public int Mantenimiento { get => mantenimiento; set => mantenimiento = value; }
    }
}

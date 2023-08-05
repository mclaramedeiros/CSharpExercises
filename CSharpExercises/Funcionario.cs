using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    class Funcionario
    {
        public string Name { get; set; }
        public double SalarioBruto { get; set; }
        public double Imposto { get; set; }
        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }
        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.0);
        }

        public override string ToString()
        {
            return Name 
            + ", R$ " 
            + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

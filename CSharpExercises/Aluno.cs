using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    class Aluno
    {
        public string Nome { get; set; }
        public double NotaPrimeiroBimestre { get; set;}
        public double NotaSegundoBimestre { get; set;}
        public double NotaTerceiroBimestre { get; set; }

        public double NotaFinal() 
        { 
            return NotaPrimeiroBimestre + NotaSegundoBimestre + NotaTerceiroBimestre;
        }
        
        public bool Aprovado()
        {
            double notafinal = NotaFinal();
            if(notafinal >= 60)
            {
                return false;
            }
            return true;
        }

        public double NotaPendente()
        {
            double notafinal = NotaFinal();
            if(notafinal >= 60)
            {
                return 0.0;
            }
            return 60 - notafinal;
        }
    }
}

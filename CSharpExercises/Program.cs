﻿using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace CSharpExercises
{
    static class Program
    {
        static void Main(string[] args)
        {
            /// Lógica Retângulo
            //Retangulo retangulo = new Retangulo();
            //Console.Write("Entre com a altura e largura do retângulo");
            //retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine("AREA = " + retangulo.Area().ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine("PERIMETRO = " + retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine("DIAGONAL = " + retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

            Funcionario funcionario = new Funcionario();
            Console.Write("Nome: ");
            funcionario.Name = Console.ReadLine();
            Console.Write("Salario bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Dados do funcionário: " + funcionario.Name, funcionario.SalarioLiquido);
            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(porcentagem);
            Console.WriteLine("Dados atualizados " + funcionario);
        }
    }
}

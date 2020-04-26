using System;
using TesteCalculoSalario.Enumerados;

namespace TesteCalculoSalario.Classes
{
    public class CalculadoraDeSalario
    {
        public double CalculaSalario(Funcionario funcionario)
        {
            if (funcionario.Salario > 3000)
            {
                return funcionario.Salario * 0.8;
            }
            
            return funcionario.Salario * 0.9;
        }
    }
}
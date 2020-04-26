using System;
using System.Collections.Generic;
using System.Text;
using TesteCalculoSalario.Enumerados;

namespace TesteCalculoSalario.Classes
{
    public class Funcionario
    {
        public String Nome { get; private set; }

        public double Salario { get; private set; }

        public Cargo Cargo { get; private set; }

        public Funcionario(string nome, double salario, Cargo cargo)
        {
            this.Nome = nome;
            this.Salario = salario;
            this.Cargo = cargo;
        }

    }
}

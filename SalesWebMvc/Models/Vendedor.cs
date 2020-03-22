using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime Aniversario { get; set; }
        public double Salario { get; set; }
        public Departamento Departamento { get; set; }
        public ICollection<RegistroVendas> Vendas { get; set; } = new List<RegistroVendas>();

        public Vendedor() 
        { 
        }

        public Vendedor(int id, string nome, string email, DateTime aniversario, double salario, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Aniversario = aniversario;
            Salario = salario;
            Departamento = departamento;
        }

        public void AddVendas(RegistroVendas ve)
        {
            Vendas.Add(ve);
        }
        public void RemoverVendas(RegistroVendas ve)
        {
            Vendas.Remove(ve);
        }
        public double TotalVendas(DateTime inicial, DateTime Final)
        {
            return Vendas.Where(x => x.Data <= inicial && x.Data >= Final).Sum(x => x.Montante);
        }

    }
}

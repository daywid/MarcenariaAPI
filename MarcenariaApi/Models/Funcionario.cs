using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarcenariaApi.Models
{
    public class Funcionario
    {
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Funcao { get; set; }
    public decimal Salario { get; set; }
    public int HorasTrabalhadas { get; set; }
    }
}
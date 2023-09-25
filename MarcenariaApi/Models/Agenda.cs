using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MarcenariaApi.Models
{
    public class Agenda
    {
    [Key]
    public int Id { get; set; }
    public string? Descricao { get; set; }
    public DateTime Data { get; set; }
    public string? Tipo { get; set; }
    public int FuncionarioId { get; set; }
    }
}
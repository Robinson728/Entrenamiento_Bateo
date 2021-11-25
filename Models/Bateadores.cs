using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Entrenamiento_Bateo.Models
{
    public class Bateadores
    {
        [Key]
        public int BateadorId { get; set; }
        public string Nombre { get; set; }
        public double Porcentaje_Bateo { get; set; }
        public double Porcentaje_Recta { get; set; }
        public double Porcentaje_Curva { get; set; }
        public double Porcentaje_Cambio { get; set; }
        public double Porcentaje_Slider { get; set; }
        public double Porcentaje_Nudillo { get; set; }
    }
}

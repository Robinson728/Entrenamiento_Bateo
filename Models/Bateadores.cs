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
        public double PorcentajeBateo { get; set; }
        public double PorcentajeRecta { get; set; }
        public double PorcentajeCurva { get; set; }
        public double PorcentajeCambio { get; set; }
        public double PorcentajeSlider { get; set; }
        public double PorcentajeNudillo { get; set; }
        public double PorcentajeHits { get; set; }
        public double PorcentajeHitsRectas { get; set; }
        public double PorcentajeHitsCurvas { get; set; }
        public double PorcentajeHitsSliders { get; set; }
        public double PorcentajeHitsCambios { get; set; }
        public double PorcentajeHitsNudillos { get; set; }
        public double BolasLanzadas { get; set; }
        public double BolasBateadas { get; set; }
        public double RectasLanzadas { get; set; }
        public double CurvasLanzadas { get; set; }
        public double SlidersLanzados { get; set; }
        public double CambiosLanzados { get; set; }
        public double NudillosLanzados { get; set; }
        public double Hits { get; set; }
        public double HitsRectas { get; set; }
        public double HitsCurvas { get; set; }
        public double HitsSliders { get; set; }
        public double HitsCambios { get; set; }
        public double HitsNudillos { get; set; }
        public double Fouls { get; set; }
        public double Afeccion { get; set; }
        public double RectasBateadas { get; set; }
        public double CurvasBateadas { get; set; }
        public double SlidersBateadas { get; set; }
        public double CambiosBateados { get; set; }
        public double NudillosBateados { get; set; }
    }
}

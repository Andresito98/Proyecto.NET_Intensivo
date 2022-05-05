using System.ComponentModel.DataAnnotations;

namespace Project_NET.Models.DataModels
{
    public class Curso: BaseEntity
    {
        [Required, StringLength(50)]
        public string Nombre { get; set; } = string.Empty;
        [Required, StringLength(280)]
        public string Descripcion_Corta { get; set; } = string.Empty;
        public string Descripcion_Larga { get; set; } = string.Empty;
        public string Publico_Objetivo { get; set; } = string.Empty;
        public string Objetivos { get; set; } = string.Empty;
        public string Requisitos { get; set; } = string.Empty;
        public enum Nivel { Basico, Intermedio, Avanzado}
    }
}

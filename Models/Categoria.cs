using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramaAcademico.Models
{
    public class Categoria
    {
        [Required(ErrorMessage ="Se neceseita llenar dato")]
        public int CategoriaId { get; set; }

        [Required(ErrorMessage ="Favor ingresar el nombre")]
        [StringLength(50, ErrorMessage ="El nombre no debe sobrepasar los 50 caracteres")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "Favor ingresar el apellido")]
        [StringLength(50, ErrorMessage = "El apellido no debe sobrepasar los 50 caracteres")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "Debe ingresar la descripción")]
        [StringLength(256,MinimumLength = 5, ErrorMessage = "El máximo es 256 y el minimo 5 caracteres")]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
        
        public bool Estado { get; set; }
    }
}

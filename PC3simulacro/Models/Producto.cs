using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PC3simulacro.Models
{
    public class Producto
    {
        public int Id {get;set;}
        
        [Required]
        [Display(Name="Nombre")]
        public string Nombre {get;set;}
        [Required]
        [Display(Name="Imagen url")]
        public string url {get;set;}
        [Required]
        [Display(Name="Descripcion")]
        public string Descripcion {get;set;}
        [Required]
        [Display(Name="Precio")]
        public string Precio {get;set;}
        [Required]
        [Display(Name="Telefono")]
        public string Telefono {get;set;}
        [Required]
        [Display(Name="Lugar de Compra")]
        public string Lugar {get;set;}
        [Required]
        [Display(Name="Nombre de Usuario")]
        public string User {get;set;}
    }
}
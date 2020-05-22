using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CafeteriaPS2.Models
{
    public class Article
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nombre del Articulo")]
        [MaxLength(50)]
        public string NameArticle { get; set; }

        [Required]
        [Display(Name = "Descripcion")]
        [MaxLength(50)]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Precio")]
        public int Price { get; set; }


    }
}
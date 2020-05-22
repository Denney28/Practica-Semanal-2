using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CafeteriaPS2.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nombre del cliente")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Telefono")]
        [MaxLength(20)]
        public string Phone { get; set; }


        [Display(Name = "Descripcion")]
        [MaxLength(50)]
        public string Description { get; set; }

        [Display(Name = "Cantidad")]
        public int Quantity { get; set; }

        public int ArticleId { get; set; }
        [ForeignKey("ArticleId")]

        public Article Article { get; set; }
    }
}
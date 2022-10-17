//--------------------------------------------------------------------------
// Imports Section
//--------------------------------------------------------------------------
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


//--------------------------------------------------------------------------
// Namespace Section
//--------------------------------------------------------------------------
namespace Hart.Entities.Models
{
    //----------------------------------------------------------------------
    // Class Section
    //----------------------------------------------------------------------
    public class Product
    {
        //------------------------------------------------------------------
        // Public Properties Section
        //------------------------------------------------------------------
        [Column("ProductId", TypeName = "CHAR(36)")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Product Description is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximum length for the Description is 30 caracters.")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Product Count is a required field.")]
        public int Count { get; set; }


        //------------------------------------------------------------------
        // Constructor Method Section
        //------------------------------------------------------------------
        public Product()
        {
            Description = "";
            Count = 0;
        }
    }
}
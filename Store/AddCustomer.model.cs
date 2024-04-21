using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Models
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {get; set}

        //properties
        public string Email {get; set}
        public string Name {get; set}
        public string Address {get; set}
        public string FavouriteFlavour {get; set}
    }
}
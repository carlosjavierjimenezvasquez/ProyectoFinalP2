﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FastFoodRestaurant.Entidades
{
    public class tbl_Menu
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int menu_id { get; set; }

        public string nombreMenu { get; set; }



        public ICollection<tbl_Combo > tbl_Combo { get; set; }
        public ICollection<tbl_Producto> tbl_Producto { get; set; }

    }
}
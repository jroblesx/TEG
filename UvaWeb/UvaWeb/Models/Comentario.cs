﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UvaWeb.Models
{
    public class Comentario
    {

        [Key]
        public int ComentarioID { get; set; }

        public int UserID { get; set; }

        public int VideoID { get; set; }

        [MaxLength(250)]
        public string Descripcion { get; set; }

        public DateTime Fecha { get; set; }

        public bool status { get; set; }
    
    }
}

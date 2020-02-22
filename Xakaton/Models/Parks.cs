using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Xakaton.Models
{
    public class Parks
    {
        public int ID { get; set; }
        public string Title { get; set; } //Название парка
        public int Address { get; set; } //Адрес парка
        public int Area { get; set; } //Размер парка
        public double Rating { get; set; } //Рэйтинг парка
        
    }
}
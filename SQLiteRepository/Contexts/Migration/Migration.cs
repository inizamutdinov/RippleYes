using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SQLiteRepository.Contexts
{
    public class Migration
    {
        [Key]
        public int Number { get; set; }

        public string Description { get; set; }
    }
}

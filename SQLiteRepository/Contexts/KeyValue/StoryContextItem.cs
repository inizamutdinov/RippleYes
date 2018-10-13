using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SQLiteRepository.Contexts
{
    [Table("Story")]
    public class StoryContextItem
    {
        [Key]
        public string Key { get; set; }

        public string Value { get; set; }
    }
}

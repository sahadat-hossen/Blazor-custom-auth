using BlazorCustomAuth.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorCustomAuth.Entities
{
    public  class Entry
    {
        [Key]
        public int Id { get; set; }
        public StatusEnum Status { get; set; }
    }
}

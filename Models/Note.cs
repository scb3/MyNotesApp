using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyNotesApp.Models
{
    public class Note
    {
       public int Id { get; set; }
        public String noteTitle { get; set; }
        public String noteDetail { get; set; }

        public Note()
        {

        }
    }
}

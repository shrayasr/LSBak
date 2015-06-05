using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSBak_Core.Models
{
    class JobDetail
    {
        public int Id { get; set; }
        public int JobId { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace gimmegif.web.host.Models
{
    public class Settings
    {
        public int Id { get; set; }
        [MaxLength(125)]
        public string InstaTags { get; set; }
    }
}

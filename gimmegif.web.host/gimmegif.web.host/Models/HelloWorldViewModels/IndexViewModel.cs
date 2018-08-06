using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gimmegif.web.host.Models.HelloWorldViewModels
{
    public class IndexViewModel
    {
        public string Info { get; set; }
        public List<IFormFile> TheImages { get; set; }
        public string TheGif { get; set; }

        public int Delay { get; set; }
        public int TextSize { get; set; }
    }
}

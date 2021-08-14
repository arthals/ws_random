using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Controllers
{
    public class Bueiro
    {
        public int Id { get; set; }
        public string Rua { get; set; }
        public string CodLocalizacao { get; set; }
        public DateTime DataAtivacao { get; set; }
    }
}

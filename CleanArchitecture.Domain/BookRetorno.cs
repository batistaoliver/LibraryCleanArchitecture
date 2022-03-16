using CleanArchitecture.Domain.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain
{
    public class BookRetorno
    {
        public List<Book> Books { get; set; }

        [JsonProperty("Status")]
        public string Status { get; set; }

        [JsonProperty("Mensagem")]
        public string Mensagem { get; set; }
        
    }
}

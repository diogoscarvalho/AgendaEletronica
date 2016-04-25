using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgendaEletronica.Models
{
    public class Contato
    {
        public Contato()
        {
            Emails = new List<Email>();
            Telefones = new List<Telefone>();
        }
        [BsonId]
        public int IdContato { get; set; }
        public string Nome { get; set; }
        public ICollection<Email> Emails { get; set; }
        public ICollection<Telefone> Telefones { get; set; }
    }
}
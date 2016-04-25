using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;
    
namespace AgendaEletronica.Models
{
    public class Telefone
    {
        [BsonId]
        public int IdTelefone { get; set; }
        [RegularExpression(@"^\([0-9]{2,3}\)[0-9]{4,5}-[0-9]{4}$", ErrorMessage="Número de telefone inválido!")]
        [Display(Name="Telefone")]
        public string Numero { get; set; }
    }
}
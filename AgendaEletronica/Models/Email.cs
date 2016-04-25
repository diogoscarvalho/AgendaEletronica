using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

namespace AgendaEletronica.Models
{
    public class Email
    {
        [BsonId]
        public int IdEmail { get; set; }
        [EmailAddress(ErrorMessage="E-mail inválido, por favor verifique o endereço informado!")]
        [Display(Name="E-mail")]
        public string EmailAddress { get; set; }
    }
}
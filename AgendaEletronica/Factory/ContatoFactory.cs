using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgendaEletronica.Factory
{
    public class ContatoFactory
    {
        public ContatoFactory()
        {

        }

        public List<Models.Contato> InicializeObject()
        {
            int j = 0;
            List<Models.Contato> contatos = new List<Models.Contato>();
            for (int i = 0; i < 10; i++)
            {
                var contato = new Models.Contato()
                {
                    IdContato = i,
                    Nome = string.Format("Contato_{0}", i),
                };

                var email = new Models.Email()
                {
                    IdEmail = j,
                    EmailAddress = string.Format("email_{0}@teste.com.br", j)
                };
                var email2 = new Models.Email()
                {
                    IdEmail = j + 1,
                    EmailAddress = string.Format("email_{0}@teste.com.br", j)
                };

                var telefone = new Models.Telefone()
                {
                    IdTelefone = j,
                    Numero = string.Format("({0}{1})12345-6789",j,j)
                };

                var telefone2 = new Models.Telefone()
                {
                    IdTelefone = j + 1,
                    Numero = string.Format("({0}{1})12345-6789", j +1, j +1)
                };

                j++;
                contato.Emails.Add(email);
                contato.Emails.Add(email2);

                contato.Telefones.Add(telefone);
                contato.Telefones.Add(telefone2);

                contatos.Add(contato);
            }

            return contatos;
        }
    }
}
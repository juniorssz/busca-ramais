using System;

namespace DTO
{
    public class Contato
    {
        public string Nome { get; set; }

        public string Setor { get; set; }

        public string Email { get; set; }

        public string Ramal { get; set; }

        public string Celular { get; set; }

        public static Contato getCSV(string csvLine)
        {
            string[] values = csvLine.Split(';');

            Contato contatos = new Contato();

            contatos.Nome = Convert.ToString(values[0]);
            contatos.Setor = Convert.ToString(values[1]);
            contatos.Email = Convert.ToString(values[2]);
            contatos.Ramal = Convert.ToString(values[3]);
            contatos.Celular = Convert.ToString(values[4]);

            return contatos;

        }
    }
}

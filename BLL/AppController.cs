using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using DTO;
using DAL;

namespace BLL
{
    public class AppController
    {
        public List<Contato> getContatosList()
        {
            List<Contato> contatos = new List<Contato>();

            try
            {
               contatos = File.ReadAllLines(ReadFile.getCsvPath()).Skip(1).Select(c => Contato.getCSV(c)).ToList();
      
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Contact Finder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            
            return contatos;
        }

    }
}

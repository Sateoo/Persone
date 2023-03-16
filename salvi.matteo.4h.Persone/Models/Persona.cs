using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salvi.matteo._4h.Persone.Models
{
    public enum TipoPersona { NonDefinito,ATA,Alunno,Docente}
    public class Persona
    {
        public TipoPersona Tipo { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Email { get; set; }
        
        /*public Persona() { }
        public Persona(string str) 
        {
            string[] colonne = str.Split(";");
            Tipo = colonne[0];
            Nome = colonne[1];
            Cognome = colonne[2];
            Email = colonne[3];
        }*/
    }
    public class ATA : Persona 
    {
        public ATA() 
        {
            Tipo = TipoPersona.ATA;
        }
    }
    /*internal class Utenti : List<Persona>
    {
        public Utenti(string filename)
        {

            StreamReader fin = new StreamReader(filename);
            fin.ReadLine();
            while (!fin.EndOfStream)
            {
                string str = fin.ReadLine();
                Add(new Persona(str));
            }
            fin.Close();


        }
    }*/
}

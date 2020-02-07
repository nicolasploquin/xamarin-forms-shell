using System.Collections.Generic;
using System.Linq;
namespace Eni.Xamarin.Models
{
    public class Client
    {
 
        public long Id { get; set; }

        private string nom = "";
        private string prenom = "";

        public string Nom
        {
            get { return nom; }
            set { nom = value.ToUpper(); }
        }
        public string Prenom
        {
            get { return prenom; }
            set
            {
                prenom = value.Length > 0 ? string.Join("-", value.ToLower()
                    .Split('-').Select(
                        p => p.Substring(0, 1).ToUpper() + p.Substring(1)
                    )
                ) : "";
            }
        }
        public string Tel { get; set; }

        public string NomComplet { 
            get {
                return string.Format(@"{0} {1}", Prenom, Nom.ToUpper());
            } 
        }

    }

    //public class InitialEqualityComparer: IEqualityComparer<Client>
    //{
    //    public bool Equals(Client cli1, Client cli2)
    //    {
    //        return cli1.Nom.ToCharArray()[0] == cli2.Nom.ToCharArray()[0];
    //    }

    //    public int GetHashCode(Client cli)
    //    {
    //        return cli == null ? 0 : (int)cli.Nom.ToCharArray()[0];
    //    }
    //}
}
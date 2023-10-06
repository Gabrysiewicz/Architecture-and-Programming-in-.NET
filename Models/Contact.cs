using System.ComponentModel;

namespace Laboratorium3.Models
{
    public class Contact
    {
        [DisplayName("Identyfikator")]
        public int Id { get; set; }

        [DisplayName("Imie")]
        public String Name { get; set; }

        [DisplayName("Nazwisko")]
        public String Surname { get; set; }

        [DisplayName("Email")]
        public String Email { get; set; }

        [DisplayName("City")]
        public String City { get; set; }

        [DisplayName("Nr. Telefonu")]
        public String PhoneNumber { get; set; }

    }
}

using System.ComponentModel.DataAnnotations.Schema;

namespace Vidly.Models {
    public class Customer {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }

        public MembershipType MembershipType { get; set; }

        public byte MemberShipId { get; set; }
    }
}
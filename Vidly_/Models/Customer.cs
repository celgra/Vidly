using System;

namespace Vidly_.Models
{
    public class Customer
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public byte MembershipTypeId { get; set; }
        public DateTime? Birthdate { get; set; }

        public MembershipType MembershipType { get; set; }
    }
}
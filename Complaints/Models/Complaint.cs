namespace Complaints.Models
{
    public class Complaint
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Customer Customer { get; set; }
        public DateTime ComplaintDate { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
    }
}

namespace Task1.Models
{
    public class Feedback
    {
        public int FeedbackId { get; set; }
        public string SenderEmail { get; set; }
        public string Message { get; set; }
        public DateTime ReceivedDate { get; set; }
    }
}

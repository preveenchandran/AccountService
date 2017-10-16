namespace AccountContract
{
    public class Office
    {
        public string Name { get; set; }
        public int LocationId { get; set; }
        public int UserId { get; set; }
        public int EntId { get; set; }

        public  EntAccount EntAccount { get; set; }
        public  Enterprise Enterprise { get; set; }
        public  Location Location { get; set; }

    }
}
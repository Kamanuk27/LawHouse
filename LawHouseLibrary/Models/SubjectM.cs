namespace LawHouseLibrary.Models
{
    // Andriy
    public class SubjectM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int HoursEstimate { get; set; }
        public decimal Price { get; set; }
        public int TimeEstimate { get; set; }

        public SubjectM()
        {

        }
        public SubjectM(int id)
        {
            Id = id;
        }

    }
}

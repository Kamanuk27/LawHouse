namespace LawHouseLibrary.Models
{
    public class ClientM
    {
        // Lisa
        public int Id { get; set; }
        public string CprNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int PostNo { get; set; }
        public string Email { get; set; }
        public string TlfNo { get; set; }

        public ClientM()
        {
            
        }

        public ClientM(int id)
        {
            Id = id;
        }
    }
}

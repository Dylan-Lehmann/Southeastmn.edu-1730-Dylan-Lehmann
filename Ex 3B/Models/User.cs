namespace Ex_3B.Models
{
    public class User
    {
        public string Name { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? Age
        {
            get
            {
                if (BirthDate.HasValue)
                {
                    return DateTime.Today.Year - BirthDate.Value.Year;
                }
                return null;
            }
        }
    }
}

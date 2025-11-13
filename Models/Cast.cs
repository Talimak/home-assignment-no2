namespace matala1y3.Models
{
    public class Cast
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Country { get; set; }

        public static List<Cast> CastsList = new List<Cast>();

        public bool Insert(Cast c)
        {
            for (int i = 0; i<CastsList.Count; i++)
            {
                if (c.Id== CastsList[i].Id)
                    return false;
            }
            CastsList.Add(c);
            return true;
        }
        public static List<Cast> Read()
        {
            return CastsList;
        }
    }

}

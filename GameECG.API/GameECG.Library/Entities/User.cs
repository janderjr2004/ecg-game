using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GameECG.Library.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Role { get; set; }
    }
}

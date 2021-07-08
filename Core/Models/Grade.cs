using System.Collections.Generic;

namespace University.Core
{
    public class Grade
    {
        public int Id { get; init; }
        public string Name { get; init; }
        
        public ICollection<Student> Students { get; init; }
    }
}

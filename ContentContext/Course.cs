using teste.ContentContext.Enums;

namespace teste.ContentContext
{
    public class Course : Content
    {
        public Course(string title, string url, EContentLevel level) : base(title, url)
        {
            Level = level;
            Modules = new List<Module>();
        }

        public string Tag { get; set; }
        public IList<Module> Modules { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }
}

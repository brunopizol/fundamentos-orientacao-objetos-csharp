using teste.NotificationContext;

namespace teste.ContentContext
{
    public class CareerItem: Base
    {
        public CareerItem(int ordem, string title, string description, Course course)
        {
            if (course == null)
                AddNotification(new Notification("Course", "Curso invalido"));
            Ordem = ordem;
            Title = title;
            Description = description;
            Course = course;
        }

        public int Ordem { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public Course Course { get; private set; }
    }
}

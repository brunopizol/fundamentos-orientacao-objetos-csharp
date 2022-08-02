// See https://aka.ms/new-console-template for more information

using teste.ContentContext;
using teste.ContentContext.Enums;
using teste.SubscriptionContext;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var articles = new List<Article>();
        articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
        articles.Add(new Article("Artigo sobre C#", "csharp"));
        articles.Add(new Article("Artigo sobre .NET", "dotnet"));

        foreach (var article in articles)
        {
            Console.WriteLine(article.Id);
            Console.WriteLine(article.Title);
            Console.WriteLine(article.Url);
        }

        var courses = new List<Course>();
        var courseOop = new Course("Fundamentos OOP", "fundamentos-oop", EContentLevel.Beginner);
        var courseCsharp = new Course(
            "Fundamentos C#",
            "fundamentos-csharp",
            EContentLevel.Fundamental
        );
        var courseAspNet = new Course(
            "Fundamentos ASP.NET",
            "fundamentos-aspdotnet",
            EContentLevel.Intermediary
        );
        courses.Add(courseOop);
        courses.Add(courseAspNet);
        courses.Add(courseCsharp);

        var careers = new List<Career>();
        var careerDotNet = new Career("Especialista .NET", "especialista-dotnet");
        var careerItem2 = new CareerItem(2, "Aprenda OOP", "", null);
        var careerItem = new CareerItem(1, "Comece por aqui", "", courseCsharp);
        var careerItem3 = new CareerItem(3, "Aprenda .NET", "", courseAspNet);
        careerDotNet.Items.Add(careerItem2);
        careerDotNet.Items.Add(careerItem);
        careerDotNet.Items.Add(careerItem3);
        careers.Add(careerDotNet);

        foreach (var career in careers)
        {
            System.Console.WriteLine(career.Title);
            foreach (var item in career.Items.OrderBy(x => x.Ordem))
            {
                System.Console.WriteLine($"{item.Ordem} - {item.Title}");
                System.Console.WriteLine(item.Course?.Title);
                System.Console.WriteLine(item.Course?.Level);

                foreach (var notification in item.Notifications)
                {
                    System.Console.WriteLine($"{notification.Property} - {notification.Message}");
                }
                var payPalSubscription = new PayPalSubscription();
                var student = new Student();
                student.CreateSubscription(payPalSubscription);
                
            }
        }
    }
}

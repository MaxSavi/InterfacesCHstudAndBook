public interface IComparable<T>
{
    int CompareTo(T other);
}
public class Student : IComparable<Student>
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Grade { get; set; }

    public int CompareTo(Student other)
    {
        int CompareAge = this.Age.CompareTo(other.Age);
        if (CompareAge != 0)
        {
            return CompareAge;
        }
        return this.Name.CompareTo(other.Name);
    }
}
public class Book : IComparable<Book>
{
    public string Title { get; set; }
    public string Author { get; set; }
    public double Price { get; set; }

    public int CompareTo(Book other)
    {
        int ComparePrice = this.Price.CompareTo(other.Price);
        if (ComparePrice != 0)
        {
            return ComparePrice;
        }
        return this.Title.CompareTo(other.Title);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student();
        student1.Name = "Вася";
        student1.Age = 18;
        student1.Grade = 3;
        Student student2 = new Student();
        student2.Name = "Петя";
        student2.Age = 17;
        student2.Grade = 2;

        int st = student1.CompareTo(student2);
        if (st < 0)
        {
            Console.WriteLine($"Студент {student1.Name} младше студента {student2.Name}");
        }
        else if (st > 0)
        {
            Console.WriteLine($"Студент {student1.Name} старше студента {student2.Name}");
        }
        else
        {
            Console.WriteLine($"{student1.Name} и {student2.Name} ровестники");
        }

        Book book1 = new Book();
        book1.Title = "Как стать миллиардером?";
        book1.Author = "Максим Савиных";
        book1.Price = 5000000;
        Book book2 = new Book();
        book2.Title = "Муму";
        book2.Author = "Ноу нейм какой-то";
        book2.Price = 10;

        int bk = book1.CompareTo(book2);
        if (bk < 0)
        {
            Console.WriteLine($"Книга \"{book1.Title}\" стоит дешевле чем книга \"{book2.Title}\"");
        }
        else if (bk > 0)
        {
            Console.WriteLine($"Книга \"{book1.Title}\" стоит дороже чем книга \"{book2.Title}\"");
        }
        else
        {
            Console.WriteLine($"Книги \"{book1.Title}\" и \"{book2.Title}\" стоят одигаково");
        }
    }
}

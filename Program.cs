using System.Text.Json;
record Book(int Id,string Title,string Author,bool Borrowed);
class Library{public List<Book> Books=new(){new(1,"Clean Code","Robert C. Martin",false),new(2,"The Pragmatic Programmer","Hunt & Thomas",false)};public void Borrow(int id){var i=Books.FindIndex(x=>x.Id==id);if(i>=0)Books[i]=Books[i] with{Borrowed=true};}public void Return(int id){var i=Books.FindIndex(x=>x.Id==id);if(i>=0)Books[i]=Books[i] with{Borrowed=false};}}
class Program{static void Main(){var l=new Library();l.Borrow(1);Console.WriteLine("C# LIBRARY SYSTEM");foreach(var b in l.Books)Console.WriteLine($"{b.Id}. {b.Title} — {(b.Borrowed?"Borrowed":"Available")}");Console.WriteLine(JsonSerializer.Serialize(l.Books));}}

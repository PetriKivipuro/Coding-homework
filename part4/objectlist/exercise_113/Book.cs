using System;

namespace exercise_113
{
  public class Book
  {
    public string title { get; set; }
    public int pages { get; set; }
    public int yearOfPublication { get; set; }

    public Book(string title, int pages, int yearOfPublication)
    {
      this.title = title;
      this.pages = pages;
      this.yearOfPublication = yearOfPublication;
    }

  }
}
using System;

namespace prep.collections
{
  public class Movie
  {
    public string title { get; set; }
    public ProductionStudio production_studio { get; set; }
    public Genre genre { get; set; }
    public int rating { get; set; }
    public DateTime date_published { get; set; }

      public int CompareTo(object obj)
      {
          var movie = obj as Movie;
          if (movie == null)
              return 0;
          return this.title.ToLower().CompareTo(movie.title.ToLower());
      }
  }
}
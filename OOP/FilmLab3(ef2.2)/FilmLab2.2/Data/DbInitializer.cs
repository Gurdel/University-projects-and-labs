using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilmLab2._2.Models;

namespace FilmLab2._2.Data
{
    public class DbInitializer
    {
        public static void Initialize(FilmContext context)
        {
            context.Database.EnsureCreated();

            if (!context.Producers.Any())
            {
                var producers = new Producer[]
                {
                    new Producer{Name = "Джеррі Брукгаймер", Birth = 1945},
                    new Producer{Name = "Тім Бертон", Birth = 1958},
                    new Producer{Name = "Кріс Коламбус", Birth = 1958},
                    new Producer{Name = "Володимир Денисенко", Birth = 1930, Death = 1984}
                };
                foreach (Producer p in producers)
                {
                    context.Producers.Add(p);
                }
                context.SaveChanges();
            }
            
            if (!context.Actors.Any())
            {
                var actors = new Actor[]
                {
                    new Actor{Name = "Джонні Депп", Birth = 1963, Death = null },
                    new Actor{Name = "Джефрі Раш", Birth = 1951, Death = null },
                    new Actor{Name = "Кіра Найтлі", Birth = 1985, Death = null },
                    new Actor{Name = "Орландо Блум", Birth = 1977, Death = null },
                    new Actor{Name = "Міа Васіковська", Birth = 1989, Death = null },
                    new Actor{Name = "Хелена Бонем Картер", Birth = 1966, Death = null },
                    new Actor{Name = "Даніель Редкліф", Birth = 1989, Death = null },
                    new Actor{Name = "Емма Вотсон", Birth = 1990, Death = null },
                    new Actor{Name = "Іван Миколайчук", Birth = 1941, Death = 1987 },
                    new Actor{Name = "Дмитро Мілютенко", Birth = 1899, Death = 1966 },
                    new Actor{Name = "Наталія Наум", Birth = 1933, Death = 2004 },
                    new Actor{Name = "Іван Кононенко-Козелецький", Birth = 1899, Death = 1972 },
                    new Actor{Name = "Раїса Недашківська", Birth = 1943, Death = null }
                };
                foreach (Actor a in actors)
                {
                    context.Actors.Add(a);
                }
                context.SaveChanges();
            }

            if (!context.Genres.Any())
            {
                var genres = new Genre[]
                {
                    new Genre{Name = "Романтика" },
                    new Genre{Name = "Триллер" },
                    new Genre{Name = "Комедія" },
                    new Genre{Name = "Пригода" },
                    new Genre{Name = "Фантастика" },
                    new Genre{Name = "Бойовик" },
                    new Genre{Name = "Сімейний" },
                    new Genre{Name = "Художній" },
                    new Genre{Name = "Біографія" },
                    new Genre{Name = "Історичний" },
                    new Genre{Name = "Драма" }
                };
                foreach (Genre g in genres)
                {
                    context.Genres.Add(g);
                }
                context.SaveChanges();
            }
            
            if (!context.Films.Any())
            {
                var films = new Film[]
                {
                    new Film{Name = "Пірати Карибського моря", Year = 2003, ProducerID = 1 },
                    new Film{Name = "Пірати Карибського моря 2", Year = 2006, ProducerID = 1 },
                    new Film{Name = "Аліса в Дивокраї", Year = 2010, ProducerID = 2 },
                    new Film{Name = "Гаррі Поттер і філософський камінь", Year = 2001, ProducerID = 3 },
                    new Film{Name = "Гаррі Поттер і таємна кімната", Year = 2002, ProducerID = 3 },
                    new Film{Name = "Сон", Year = 1964, ProducerID = 4 }
                };
                foreach (Film f in films)
                {
                    context.Films.Add(f);
                }
                context.SaveChanges();
            }
            
            if (!context.FilmsActors.Any())
            {
                var filmsactors = new FilmActor[]
                {
                    new FilmActor{FilmID = 1, ActorID = 1 },
                    new FilmActor{FilmID = 1, ActorID = 3 },
                    new FilmActor{FilmID = 1, ActorID = 2 },
                    new FilmActor{FilmID = 1, ActorID = 4 },
                    new FilmActor{FilmID = 2, ActorID = 1 },
                    new FilmActor{FilmID = 2, ActorID = 3 },
                    new FilmActor{FilmID = 2, ActorID = 2 },
                    new FilmActor{FilmID = 2, ActorID = 4 },
                    new FilmActor{FilmID = 3, ActorID = 1 },
                    new FilmActor{FilmID = 3, ActorID = 5 },
                    new FilmActor{FilmID = 3, ActorID = 6 },
                    new FilmActor{FilmID = 4, ActorID = 8 },
                    new FilmActor{FilmID = 4, ActorID = 7 },
                    new FilmActor{FilmID = 5, ActorID = 8 },
                    new FilmActor{FilmID = 5, ActorID = 7 },
                    new FilmActor{FilmID = 6, ActorID = 9 },
                    new FilmActor{FilmID = 6, ActorID = 10 },
                    new FilmActor{FilmID = 6, ActorID = 11 },
                    new FilmActor{FilmID = 6, ActorID = 12 },
                    new FilmActor{FilmID = 6, ActorID = 13 }
                };
                foreach (FilmActor fa in filmsactors)
                {
                    context.FilmsActors.Add(fa);
                }
                context.SaveChanges();
            }
            
            if (!context.FilmsGenres.Any())
            {
                var filmsgenres = new FilmGenre[]
                {
                    new FilmGenre{FilmID = 1, GenreID = 5 },
                    new FilmGenre{FilmID = 1, GenreID = 6 },
                    new FilmGenre{FilmID = 1, GenreID = 4 },
                    new FilmGenre{FilmID = 2, GenreID = 6 },
                    new FilmGenre{FilmID = 2, GenreID = 4 },
                    new FilmGenre{FilmID = 3, GenreID = 7 },
                    new FilmGenre{FilmID = 3, GenreID = 5 },
                    new FilmGenre{FilmID = 3, GenreID = 4 },
                    new FilmGenre{FilmID = 4, GenreID = 7 },
                    new FilmGenre{FilmID = 4, GenreID = 5 },
                    new FilmGenre{FilmID = 4, GenreID = 4 },
                    new FilmGenre{FilmID = 5, GenreID = 5 },
                    new FilmGenre{FilmID = 5, GenreID = 4 },
                    new FilmGenre{FilmID = 6, GenreID = 8 },
                    new FilmGenre{FilmID = 6, GenreID = 9 },
                    new FilmGenre{FilmID = 6, GenreID = 10 },
                    new FilmGenre{FilmID = 6, GenreID = 11 }
                };
                foreach (FilmGenre fg in filmsgenres)
                {
                    context.FilmsGenres.Add(fg);
                }
                context.SaveChanges();
            }
        }
    }
}

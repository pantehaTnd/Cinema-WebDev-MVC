using Project.Data.Enums;
using Project.Models;

namespace Project.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            Logo= "https://www.shutterstock.com/image-vector/cinema-movie-logo-design-letter-c-2117069372",
                            Description= "This is the description of the first cinema "
                        },
                        new Cinema()
                        {

                            Name = "Cinema 2",
                            Logo = "https://www.shutterstock.com/image-vector/cinema-movie-logo-design-letter-c-2117069372",
                            Description = "This is the description of the second cinema "
                        },
                         new Cinema()
                         {

                             Name = "Cinema 3",
                             Logo = "https://www.shutterstock.com/image-vector/cinema-movie-logo-design-letter-c-2117069372",
                             Description = "This is the description of the third cinema "
                         },
                          new Cinema()
                          {

                              Name = "Cinema 4",
                              Logo = "https://www.shutterstock.com/image-vector/cinema-movie-logo-design-letter-c-2117069372",
                              Description = "This is the description of the forfth cinema "
                          },
                           new Cinema()
                           {

                               Name = "Cinema 5",
                               Logo = "https://www.shutterstock.com/image-vector/cinema-movie-logo-design-letter-c-2117069372",
                               Description = "This is the description of the fifth cinema "
                           },
                    });
                    context.SaveChanges();
                }
                //Actors 
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            ActorName = "Actor 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureUrl = "https://www.shutterstock.com/image-photo/cannes-france-may-11-actor-600w-201325727.jpg"

                        },
                        new Actor()
                        {
                            ActorName = "Actor 2",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureUrl = "https://www.shutterstock.com/image-photo/cannes-france-may-11-actor-600w-201325727.jpg"

                        },
                        new Actor()
                        {
                            ActorName = "Actor 3",
                            Bio = "This is the Bio of the third actor",
                            ProfilePictureUrl = "https://www.shutterstock.com/image-photo/cannes-france-may-11-actor-600w-201325727.jpg"

                        },
                        new Actor()
                        {
                            ActorName = "Actor 4",
                            Bio = "This is the Bio of the fourth actor",
                            ProfilePictureUrl = "https://www.shutterstock.com/image-photo/cannes-france-may-11-actor-600w-201325727.jpg"

                        },
                        new Actor()
                        {
                            ActorName = "Actor 5",
                            Bio = "This is the Bio of the fifth actor",
                            ProfilePictureUrl = "https://www.shutterstock.com/image-photo/cannes-france-may-11-actor-600w-201325727.jpg"

                        },


                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            ProducerName = "Producer 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureUrl = "https://www.shutterstock.com/image-photo/cannes-france-may-23-jury-600w-205475797.jpg"

                        },
                        new Producer()
                        {
                            ProducerName = "Producer 2",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureUrl = "https://www.shutterstock.com/image-photo/cannes-france-may-23-jury-600w-205475797.jpg"

                        },
                        new Producer()
                        {
                            ProducerName = "Producer 3",
                            Bio = "This is the Bio of the third actor",
                            ProfilePictureUrl = "https://www.shutterstock.com/image-photo/cannes-france-may-23-jury-600w-205475797.jpg"

                        },
                        new Producer()
                        {
                            ProducerName = "Producer 4",
                            Bio = "This is the Bio of the fourth actor",
                            ProfilePictureUrl = "https://www.shutterstock.com/image-photo/cannes-france-may-23-jury-600w-205475797.jpg"

                        },
                        new Producer()
                        {
                            ProducerName = "Producer 5",
                            Bio = "This is the Bio of the fifth actor",
                            ProfilePictureUrl = "https://www.shutterstock.com/image-photo/cannes-france-may-23-jury-600w-205475797.jpg"

                        }


                    });
                    context.SaveChanges();

                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "The Shawshank Redemption",
                            Description = "This is the Shawshank Redemption movie description",
                            Price = 39.50,
                            ImageURL = "https://i.pinimg.com/564x/ec/03/dd/ec03dd387460324479bdf7a4885e1141.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 3,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "The Shawshank Redemption",
                            Description = "This is the Shawshank Redemption description",
                            Price = 29.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Ghost",
                            Description = "This is the Ghost movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 4,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.Horror
                        },
                        new Movie()
                        {
                            Name = "Race",
                            Description = "This is the Race movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaId = 1,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "Scoob",
                            Description = "This is the Scoob movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Cartoon
                        },
                        new Movie()
                        {
                            Name = "Cold Soles",
                            Description = "This is the Cold Soles movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Drama
                        }
                    });
                    context.SaveChanges();

                }
                //Scotrs & Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 1
                        },

                         new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                         new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 2
                        },

                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 3
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 4
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 5
                        },


                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 6
                        },
                    });
                    context.SaveChanges();
                }


            }
        }
    }
}

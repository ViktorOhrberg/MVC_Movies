using Movies.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Models
{
    public class MovieService
    {
        static List<MovieBoxVM> Filmer = new List<MovieBoxVM>
        {
            new MovieBoxVM { MovieID = 1, Title = "Harry Potter", Message="En ung trollkarl räddar världen" },
            new MovieBoxVM { MovieID = 2, Title = "Mad Max: Fury Road", Message="Postapokalyptiskt bilåkande i öken" },
            new MovieBoxVM { MovieID = 3, Title = "Sagan om ringen", Message="Korta människor jobbar hårt för att ta en ring till en vulkan" }
        };
        internal MovieBoxVM GetMovieBoxVM(int id)
        {
            return Filmer
                .FirstOrDefault(f => f.MovieID == id);
        }

        internal int GetMovieQuantity()
        {
            return Filmer.Count();
        }
    }
}

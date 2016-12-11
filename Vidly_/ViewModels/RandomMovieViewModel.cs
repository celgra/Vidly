using System.Collections.Generic;
using Vidly_.Models;

namespace Vidly_.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
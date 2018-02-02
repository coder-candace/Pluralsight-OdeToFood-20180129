using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using OdeToFood.Models;

namespace OdeToFood.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }
}
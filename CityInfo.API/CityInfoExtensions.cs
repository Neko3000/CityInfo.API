using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityInfo.API.Entities;
using CityInfo.API.Models;

namespace CityInfo.API
{
    public static class CityInfoExtensions
    {
        public static void EnsureSeedDataForContext(this CityInfoContext context)
        {
            if(context.Cities.Any())
            {
                return;
            }

            var cities = new List<City>()
            {
                new City
                {
                    Name = "New York City",
                    Description = "The one with  that big park.",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Name = "Center Park",
                            Description = "The most visited urban park in the United States."
                        },
                        new PointOfInterest()
                        {
                            Name = "Empire State Building",
                            Description = "A 102-story skyscraper located in Midtown Mahattan."
                        }
                     }
                },
                new City
                {
                    Name = "Antwerp",
                    Description = "The one with the catheral that was never really finished.",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Name = "Cathedral of Our Lady",
                            Description = "A gothic style cathdral, conceived by architexts Jan and Pieter Appelmans."
                        },
                        new PointOfInterest()
                        {
                            Name = "Antwerp Central Station",
                            Description = "The finest example of railway architecture in Belgium."
                        }
                     }
                },
                new City
                {
                     Name = "Paris",
                    Description = "The one with that eiffel tower.",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Name = "Eiffel Tower",
                            Description = "A wrough iron lattice tower on the Chamep de Mars, named after engineer Gustave Eiffel built it."
                        },
                        new PointOfInterest()
                        {
                            Name = "The Louvre",
                            Description = "The world's largest museum."
                        }
                     }
                }
            };

            context.Cities.AddRange(cities);
            context.SaveChanges();
        }
    }
}

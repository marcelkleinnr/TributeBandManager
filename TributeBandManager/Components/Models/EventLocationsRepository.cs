namespace TributeBandManager.Components.Models
{
    public static class EventLocationsRepository
    {
        private static List<EventLocation> eventLocations = new List<EventLocation>
        {
            new EventLocation { Id = 1, Name = "Andernach Rockt", City = "Andernach" },
            new EventLocation { Id = 2, Name = "Stadtfest Aschaffenburg", City = "Aschaffenburg" },
            new EventLocation { Id = 3, Name = "Deichstadtfest Neuwied", City = "Neuwied" },
            new EventLocation { Id = 4, Name = "Rhein in Flammen", City = "Koblenz" },
            new EventLocation { Id = 5, Name = "Burgfestspiele Mayen", City = "Mayen" },
            new EventLocation { Id = 6, Name = "Kultur im Park", City = "Bad Neuenahr-Ahrweiler" },
            new EventLocation { Id = 7, Name = "Rock am Ring", City = "Koblenz" },
            new EventLocation { Id = 8, Name = "Summerjam Festival", City = "Koblenz" },
            new EventLocation { Id = 9, Name = "Open Flair Festival", City = "Koblenz" },
            new EventLocation { Id = 10, Name = "Wacken Open Air", City = "Neuwied" },
            new EventLocation { Id = 11, Name = "Hurricane Festival", City = "Neuwied" },
            new EventLocation { Id = 12, Name = "Southside Festival", City = "Neuwied" },
            new EventLocation { Id = 13, Name = "Fusion Festival", City = "Andernach" },
            new EventLocation { Id = 14, Name = "Melt! Festival", City = "Andernach" },
            new EventLocation { Id = 15, Name = "Parookaville", City = "Andernach" }
        };

        public static void AddEventLocation(EventLocation eventLocation)
        {
            int maxId = eventLocations.Any() ? eventLocations.Max(el => el.Id) : 0;
            eventLocation.Id = maxId + 1;
            eventLocations.Add(eventLocation);
        }

        public static List<EventLocation> GetEventLocations() => eventLocations;

        public static List<EventLocation> GetEventLocationsByCity(string city)
        {
            return eventLocations.Where(el => el.City?.Equals(city, StringComparison.OrdinalIgnoreCase) == true).ToList();
        }

        public static EventLocation? GetEventLocationById(int id)
        {
            EventLocation? eventLocation = eventLocations.FirstOrDefault(el => el.Id == id);

            if (eventLocation != null)
            {
                return new EventLocation
                {
                    Id = eventLocation.Id,
                    Name = eventLocation.Name,
                    City = eventLocation.City,
                    Distance = eventLocation.Distance,
                    Region = eventLocation.Region
                };
            }
            else
            {
                return null;
            }
        }

        public static void UpdateEventLocation(EventLocation eventLocation)
        {
            EventLocation? eventLocationToUpdate = eventLocations.FirstOrDefault(el => el.Id == eventLocation.Id);
            if (eventLocationToUpdate != null)
            {
                eventLocationToUpdate.Name = eventLocation.Name;
                eventLocationToUpdate.City = eventLocation.City;
                eventLocationToUpdate.Distance = eventLocation.Distance;
                eventLocationToUpdate.Region = eventLocation.Region;
            }
        }

        public static bool DeleteEventLocation(int id)
        {
            EventLocation? eventLocationToDelete = eventLocations.FirstOrDefault(el => el.Id == id);
            if (eventLocationToDelete != null)
            {
                eventLocations.Remove(eventLocationToDelete);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static List<EventLocation> SearchEventLocations(string searchTerm)
        {
            List<EventLocation> eventLocationResults = eventLocations
                .Where(el => (el.Name != null && el.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)) ||
                             (el.City != null && el.City.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)) ||
                             (el.Region != null && el.Region.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)))
                .ToList();

            return eventLocationResults;
        }
    }
}

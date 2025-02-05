using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Properties.Models
{
    public class UserStory
    {
        private static int nextId = 1;
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public int BusinessValue { get; set; }
        public DateTime CreationDate { get; set; }
        public int Priority { get; set; }
        public string StoryPoints { get; set; }

        public UserStory(string title, string description, int businessValue, DateTime creationDate, int priority, string storyPoints)
        {
            Id = nextId++;
            Title = title;
            Description = description;
            BusinessValue = businessValue;
            CreationDate = DateTime.Today;
            Priority = priority;
            StoryPoints = storyPoints;
        }

        public UserStory()
        {
            
        }
        
        
        
    }
}
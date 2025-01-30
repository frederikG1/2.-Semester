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

        public UserStory(string title, string description)
        {
            Id = nextId++;
            Title = title;
            Description = description;
        }

        public UserStory()
        {
            
        }
        
        
        
    }
}
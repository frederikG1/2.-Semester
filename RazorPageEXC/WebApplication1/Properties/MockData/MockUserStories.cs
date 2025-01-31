using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Properties.Models;

namespace WebApplication1.Properties.MockData
{
    public class MockUserStories
    {
        private static List<UserStory> userStories = new List<UserStory>
        {
            new UserStory("User Story 1", "As a user, I want to be able to create a new user story so that I can keep track of my work.", 10, DateTime.Now, 1, "Large" ),
            new UserStory("User Story 2", "As a user, I want to be able to view a list of user stories so that I can see what work needs to be done.", 8, DateTime.Now, 2, "Medium"),
            new UserStory("User Story 3", "As a user, I want to be able to edit a user story so that I can update the details as needed.", 6, DateTime.Now, 3, "Small"),
            new UserStory("User Story 4", "As a user, I want to be able to delete a user story so that I can remove it from the list.", 4, DateTime.Now, 4, "Extra Small")
        };

        public static List<UserStory> GetMockUserStories()
        {
            return userStories;
        }

        public MockUserStories()
        {
            
        }
    
    }
}
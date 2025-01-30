using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Properties.Models;
using WebApplication1.Properties.MockData;

namespace WebApplication1.Properties.Services
{
    public class UserStoryService
    {
        private List<UserStory> userStories;

        public UserStoryService()
        {
            userStories = MockUserStories.GetMockUserStories();
        }

        public List<UserStory> GetUserStories()
        {
            return userStories;
        }
        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Properties.Models;
using WebApplication1.Properties.MockData;
using Microsoft.AspNetCore.Mvc;

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

        public UserStory GetUserStory(int id)
        {
            foreach (UserStory userStory in userStories)
            {
                if (userStory.Id == id)
                {
                    return userStory;
                }
            }
            return null;
        }

        public UserStory CreateUserStory(int id)
        {
            UserStory userStory = new UserStory();
            userStory.Id = id;
            userStories.Add(userStory);
            return userStory;
        }

        public UserStory DeleteUserStory(int userStoryId)
        {
            UserStory userstoryToBeDeleted = null;
            foreach (UserStory us in userStories)
            {
                if (us.Id == userStoryId)
                {
                    userstoryToBeDeleted = us;
                    break;
                }
            }
            if (userstoryToBeDeleted != null)
            {
                userStories.Remove(userstoryToBeDeleted);
            }
            return userstoryToBeDeleted;
        }

        /*public UserStory DeleteUserStory(int userStoryId)
        {
            var userstoryToBeDeleted = userStories.FirstOrDefault(us => us.Id == userStoryId);
            if (userstoryToBeDeleted != null)
            {
                userStories.Remove(userstoryToBeDeleted);
            }
            return userstoryToBeDeleted;
        }*/
        
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebApplication1.Properties.Services;
using WebApplication1.Properties.Models;

namespace WebApplication1.Pages
{
    public class UserStoriesModel : PageModel
    {
        private UserStoryService userStoryService;
        
        public List<UserStory> UserStoriesList { get; private set; }

        public UserStoriesModel(UserStoryService userStoryService)
        {
            this.userStoryService = userStoryService;
        }

        public void OnGet()
        {
            UserStoriesList = userStoryService.GetUserStories();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebApplication1.Properties.Models;
using WebApplication1.Properties.Services;

namespace WebApplication1.Pages
{
    public class UserStoryDetail : PageModel
    {
        [BindProperty]

        public UserStory UserStory { get; set; }
        public List<UserStory> UserStories { get; private set; }
        private UserStoryService userStoryService;

        public UserStoryDetail(UserStoryService userStoryService)
        {
            this.userStoryService = userStoryService;
        }

        public void OnGet(int id)
        {
            UserStories = userStoryService.GetUserStories();
            UserStory = userStoryService.GetUserStory(id);
        }

        public IActionResult OnPost()
        {
            return RedirectToPage("UserStories");
        }
        
    }
}
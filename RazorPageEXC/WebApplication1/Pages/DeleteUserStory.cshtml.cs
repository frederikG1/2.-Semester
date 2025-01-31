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
    public class DeleteUserStoryModel : PageModel
    {
        private UserStoryService userStoryService;

        [BindProperty]
        public UserStory UserStory { get; set; }
        private readonly ILogger<DeleteUserStoryModel> _logger;

        public DeleteUserStoryModel(UserStoryService userStoryService)
        {
            this.userStoryService = userStoryService;
        }

        public void OnGet(int id)
        {
            UserStory = userStoryService.GetUserStory(id);
        }

        public IActionResult OnPost()
        {
            UserStory deletedUserStory = userStoryService.DeleteUserStory(UserStory.Id);
            return RedirectToPage("UserStories");
        }
    }
}
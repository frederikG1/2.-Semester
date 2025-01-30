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
        private readonly UserStoryService _userStoryService;
        private readonly ILogger<UserStoriesModel> _logger;
        public List<UserStory> UserStoriesList { get; private set; }

        public UserStoriesModel(UserStoryService userStoryService, ILogger<UserStoriesModel> logger)
        {
            _userStoryService = userStoryService;
            _logger = logger;
        }

        public void OnGet()
        {
            UserStoriesList = _userStoryService.GetUserStories();
        }
    }
}
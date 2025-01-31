using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebApplication1.Properties.Models;
using WebApplication1.Properties.Services;
using WebApplication1.Properties.MockData;

namespace WebApplication1.Pages
{
    public class CreateUserStoryModel : PageModel
    {
        
        private UserStoryService userStoryService;
        [BindProperty]
        public UserStory UserStory { get; set; }
        [BindProperty]
        public UserStory AreChecked { get; set; }
        [BindProperty]
        public UserStory Prioritet { get; set; }
        [BindProperty]
        public List<int> RadioValues => Enumerable.Range(1, 10).ToList();
        
        public Dictionary<int, string> PriorityValues = new Dictionary<int, string>
        {
            {1, "Very Important"},
            {2, "Important"},
            {3, "Useful"},
            {4, "Not Important"},
            {5, "Not Useful"}
        };
        

        public CreateUserStoryModel(UserStoryService userStoryService)
        {
            this.userStoryService = userStoryService;
        }
        public void OnGet()
        {
            UserStory = new UserStory();
            
        }
        
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            userStoryService.CreateUserStory(UserStory.Id);
            return RedirectToPage("UserStories");
        }
    }
}
using Blog_Escola_Dotnet.Areas.Identity.Data;
using Blog_Escola_Dotnet.BusinessManager.Interfaces;
using Blog_Escola_Dotnet.Models.BlogViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Storage;
using System.Reflection.Metadata;
using System.Security.Claims;

namespace Blog_Escola_Dotnet.BusinessManager
{
    public class BlogBusinessManager : IBlogBusinessManager
    {
        private readonly UserManager<ApplicationUser> _userManager;
        public BlogBusinessManager(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<Blog> CreateBlog(CreateBlogViewModel createBlogViewModel, ClaimsPrincipal claimsPrincipal)
        {
            Blob blog = new Blog
            {
                Creator = await userManeger.GetUserAsync(claimsPrincipal),
                CreatedAt = DateTime.Now;
            }

        }
    }
}

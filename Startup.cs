using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace aspnetcoreapp
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.Run(context =>
            {
                return context.Response.WriteAsync("asdf");
                // using (var db = new BloggingContext()) {
                //     // Add a blog
                //     db.Blogs.Add(new Blog {Url = "google.com"});
                //     await db.SaveChangesAsync();
                    
                //     // Display all blogs
                //     var query = from d in db.Blogs where d.Url != "" select d;
                //     await context.Response.WriteAsync(JsonConvert.SerializeObject(query.ToArray()));
                // }
            });
        }
    }
}
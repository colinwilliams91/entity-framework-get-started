using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

public class Blog
{
    public int BlogId { get; set; }
    public string Url { get; set; }
    public DateTime CreatedTimestamp { get; set; }

    public List<Post> Posts { get; } = new();
}

public class Post
{
    public int PostId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }

    public int BlogId { get; set; }
    public Blog Blog { get; set; }
}

/*
 * Run commands:
 * ---
 * dotnet tool install --global dotnet-ef
 * dotnet add package Microsoft.EntityFrameworkCore.Design
 * dotnet ef migrations add InitialCreate
 * dotnet ef database update
 */

/*
 * This installs `dotnet ef` and the design package which is required to run the command on a project.
 * The `migrations` command scaffolds a migration to create the initial set of tables for the model. The
 * `database update` command creates the database and applies the new migration to it.
 */

/*
 * added Timestamp to Blog Model -- run the following commands to sync production DB with Model (with new column in Schema):
 * create a new migration:
 * `dotnet ef migrations add AddBlogCreatedTimestamp`
 * 
 * apply migration:
 * `dotnet ef database update`
 */

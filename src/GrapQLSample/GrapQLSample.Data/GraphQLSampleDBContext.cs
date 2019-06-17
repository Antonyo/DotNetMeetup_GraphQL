using GrapQLSample.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using GrapQLSample.Common.Extensions;

namespace GrapQLSample.Data
{
    public class GraphQLSampleDBContext : DbContext
    {
        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Movie> Movies { get; set; }

        public GraphQLSampleDBContext() : base() { }
        public GraphQLSampleDBContext(DbContextOptions<GraphQLSampleDBContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            var attendees = new List<Attendee>();
            attendees.FromJson("./employees.json");

            builder.Entity<Attendee>().HasData(attendees);
        }
    }
}

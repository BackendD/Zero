using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Zero.DomainModel;
namespace Zero.Repositories.EntityFrameworkRepository
{
	class ZeroContext : DbContext
	{
		public ZeroContext(string connectionString) : base(connectionString) { }
		public DbSet<School> Schools { get; set; }
		public DbSet<Room> Rooms { get; set; }
		public DbSet<Course> Courses { get; set; }
		public DbSet<Person> People { get; set; }
		public DbSet<Teacher> Teachers { get; set; }
		public DbSet<Address> Addresses { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{

		}
	}
}

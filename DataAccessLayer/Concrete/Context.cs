using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<Creator, CreatorRole, int>
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        //public Context(DbContextOptions<Context> options) : base(options)
        //{
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=IBRAHIMBEKTAS\\SQLEXPRESS;Initial Catalog=SurveyNew2;Integrated Security=True;Encrypt=False");
        }

        public DbSet<Answer> Answers { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Survey> Surveys { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ConditionalQuestion> ConditionalQuestions { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<Response> Responses { get; set; }
        public DbSet<TextAnswer> TextAnswers { get; set; }
        public DbSet<OptionAnswer> OptionAnswers { get; set; }
        public DbSet<FileAnswer> FileAnswers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<TextAnswer>().ToTable("TextAnswers");
            builder.Entity<OptionAnswer>().ToTable("OptionAnswers");
            builder.Entity<FileAnswer>().ToTable("FileAnswers");

            base.OnModelCreating(builder);

        }
    }
}

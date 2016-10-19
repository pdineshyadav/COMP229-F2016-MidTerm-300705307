namespace COMP229_F2016_MidTerm_300705307.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TodoContext : DbContext
    {
        public TodoContext()
            : base("name=TodoContext")
        {
        }

        public virtual DbSet<TodoTable> TodoTables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoTable>()
                .Property(e => e.TodoDescription)
                .IsUnicode(false);

            modelBuilder.Entity<TodoTable>()
                .Property(e => e.TodoNotes)
                .IsUnicode(false);
        }
    }
}

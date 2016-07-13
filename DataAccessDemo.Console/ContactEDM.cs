namespace DataAccessDemo.Console
{
    using System.Data.Entity;

    public class ContactEdm : DbContext
    {
        public ContactEdm()
            : base("name=ContactEdm")
        {
        }

        public virtual DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

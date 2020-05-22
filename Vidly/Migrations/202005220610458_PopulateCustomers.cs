namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomers : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Customers (Name, IsSubscribedToNewsletter , MembershipTypeId) values('Steve Jobs',1,1)");
            Sql("Insert into Customers (Name, IsSubscribedToNewsletter , MembershipTypeId) values('Bill Gates',0,2)");
            Sql("Insert into Customers (Name, IsSubscribedToNewsletter , MembershipTypeId) values('Mike Jackson', 1,3)");                        
        }
        
        public override void Down()
        {
        }
    }
}

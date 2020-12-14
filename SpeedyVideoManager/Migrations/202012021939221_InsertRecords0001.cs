namespace SpeedyVideoManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertRecords0001 : DbMigration
    {
        public override void Up()
        {

            Sql("insert into Movies(Title,ReleaseYear,RuntimeMinutes,Summary,Details) " +
                "values('Alien',1979,117,'Space truckers freak out over a spider.','')," +
                "('Aliens',1986,137,'Marines bring a little girl home.','')," +
                "('Terminator',1984,107,'A man from the future obsesses about a woman today', '')," +
                "('Tremors',1990,96,'A small town has worms','')");

            Sql("insert into Customers(FirstName,LastName, City,ZipPostal) " +
                "values('John','Bon Jovi','Los Angeles','90210')," +
                "('Doug','Funny','Sacremento','92346')," +
                "('Sigorney','Weaver','Branson','76385')," +
                "('Alfred','Yankovic','Lynwood','97362')");

            Sql("insert into MembershipTypes (MembershipType,Price,DurationMonths) " +
               "values('Basic',0,0)," +
               "('Standard',4.99,1)," +
               "('Silver',49.99,12)," +
               "('Gold',100.00,12)");
        }
        
        public override void Down()
        {
        }
    }
}

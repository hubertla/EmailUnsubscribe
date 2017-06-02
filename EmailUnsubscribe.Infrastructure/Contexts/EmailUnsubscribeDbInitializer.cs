using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailUnsubscribe.Infrastructure.Contexts
{
    public class EmailUnsubscribeDbCreateInitializer : CreateDatabaseIfNotExists<EmailUnsubscribeDbContext>
    {
        protected override void Seed(EmailUnsubscribeDbContext context)
        {


            base.Seed(context);
        }
    }
}

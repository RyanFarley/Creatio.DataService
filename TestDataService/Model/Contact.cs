﻿using Creatio.DataService.Attributes;
using System;

namespace TestDataService.Model
{
    [RootSchemaName("Contact")]
    class Contact
    {
        [QueryColumn("Id")]
        public Guid Id { get; set; }

        [QueryColumn("Name")]
        public string Name { get; set; }
        
        [QueryColumn("Email")]
        public string Email { get; set; }
        
        [QueryColumn("CreatedOn")]
        public DateTime CreatedOn { get; set; }

        [QueryColumn("ModifiedOn")]
        public DateTime ModifiedOn { get; set; }

        [RootSchemaName("Account")]
        public Account Account { get; set; }

    }
}
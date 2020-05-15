﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TenantsAssociation.ApplicationLogic.Exceptions
{
    public class UserHasNoInvoiceException : Exception
    {
        public UserHasNoInvoiceException() : base($"Current user has no invoices") { }
    }
}

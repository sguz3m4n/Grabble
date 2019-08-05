using Grabble.Data.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Grabble.Data.Domain.BIlling
{
    [Table("BillingDetail")]
    public class BillingDetail:Address
    {
    }
}

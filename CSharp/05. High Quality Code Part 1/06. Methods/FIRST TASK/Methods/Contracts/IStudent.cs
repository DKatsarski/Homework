using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.Contracts
{
    public interface IStudent
    {
        string FirstName { get; set; }
        
        string LastName { get; set; }
        
        string DateOfBirth { get; set; }

        string HomeTown { get; set; }

        string Hobby { get; set; }

        string Score { get; set; }

    }
}

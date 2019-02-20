using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App1.Models
{
    public interface IFirebaseAuthenticator
    {
        Task<string> LoginWithEmailPassword(string email, string password);
    }
}

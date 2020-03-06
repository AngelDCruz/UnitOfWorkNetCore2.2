using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Repository.Contracts
{
    public interface IUnit : IDisposable
    {

        Task Commit();

    }
}

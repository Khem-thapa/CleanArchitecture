using CleanArch.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Core.Bus
{
    /// <summary>
    /// it has one method to design messging system
    /// </summary>
    public interface IMeditorHandler
    {
        Task SendCommand<T>(T Command) where T : Command;
    }
}

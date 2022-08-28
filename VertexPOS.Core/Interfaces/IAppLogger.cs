using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VertexPOS.Core.Interfaces
{
    public interface IAppLogger<T>
    {
        void LogInformation(string message, params object[] args);
        void LogWarning(string message, params object[] args);
        void LogError(string message, params object[] args);
        void LogCritical(string message, params object[] args);
    }
}

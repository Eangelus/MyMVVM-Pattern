using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Pattern.Exceptions
{
    internal class GolbalConflictExceptions : Exception
    {
        public GolbalConflictExceptions()
        {
        }

        public GolbalConflictExceptions(string message) : base(message)
        {
        }

        public GolbalConflictExceptions(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected GolbalConflictExceptions(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

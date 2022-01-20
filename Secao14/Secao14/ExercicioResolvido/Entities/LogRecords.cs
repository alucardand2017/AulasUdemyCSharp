using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioResolvido.Entities
{
    class LogRecords
    {
        public string UserName { get; set; }
        public DateTime Instant { get; set; }

        public LogRecords(string userName, DateTime instant)
        {
            UserName = userName;
            Instant = instant;
        }

        public override int GetHashCode()
        {
            return UserName.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (!(obj is LogRecords))
                return false;
            LogRecords other = obj as LogRecords;
            return UserName.Equals(other.UserName);
        }
    }
}

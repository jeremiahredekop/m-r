using System.Linq;

namespace SimpleCQRS.Events
{
    public class Event : IMessage
    {
        public int Version;
    }
}
using System.Linq;

namespace SimpleCQRS.Bus
{
    public interface IHandles<in T>
    {
        void Handle(T message);
    }
}
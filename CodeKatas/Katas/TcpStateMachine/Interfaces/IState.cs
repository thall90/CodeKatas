using System.Collections.Generic;

namespace CodeKatas.Katas.TcpStateMachine.Interfaces
{
    public interface IState
    {
        string Value { get; }

        IState Transition(string @event);
    }
}
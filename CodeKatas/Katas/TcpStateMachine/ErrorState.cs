using CodeKatas.Katas.TcpStateMachine.Interfaces;

namespace CodeKatas.Katas.TcpStateMachine
{
    public class ErrorState : IState
    {
        public string Value => "ERROR";
        
        public IState Transition(string @event)
        {
            return new ErrorState();
        }
    }
}
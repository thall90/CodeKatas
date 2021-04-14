using CodeKatas.Katas.TcpStateMachine.Interfaces;

namespace CodeKatas.Katas.TcpStateMachine
{
    public class ClosedState : IState
    {
        public string Value => "CLOSED";
        
        public IState Transition(string @event)
        {
            // CLOSED: APP_PASSIVE_OPEN -> LISTEN
            if (@event == TcpEvents.AppPassiveOpen)
            {
                return new ListenState();
            }
            
            // CLOSED: APP_ACTIVE_OPEN  -> SYN_SENT
            if (@event == TcpEvents.AppActiveOpen)
            {
                return new SynSentState();
            }
            
            return new ErrorState();
        }
    }
}
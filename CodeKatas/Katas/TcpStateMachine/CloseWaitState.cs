using CodeKatas.Katas.TcpStateMachine.Interfaces;

namespace CodeKatas.Katas.TcpStateMachine
{
    public class CloseWaitState : IState
    {
        public string Value => "CLOSE_WAIT";
        
        public IState Transition(string @event)
        {
            // CLOSE_WAIT: APP_CLOSE -> LAST_ACK
            if (@event == TcpEvents.AppClose)
            {
                return new LastAckState();
            }
            
            return new ErrorState();
        }
    }
}
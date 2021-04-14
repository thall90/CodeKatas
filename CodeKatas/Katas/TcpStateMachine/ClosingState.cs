using CodeKatas.Katas.TcpStateMachine.Interfaces;

namespace CodeKatas.Katas.TcpStateMachine
{
    public class ClosingState : IState
    {
        public string Value => "CLOSING";
        
        public IState Transition(string @event)
        {
            // CLOSING: RCV_ACK -> TIME_WAIT
            if (@event == TcpEvents.RcvAck)
            {
                return new TimeWaitState();
            }
            
            return new ErrorState();
        }
    }
}
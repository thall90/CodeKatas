using CodeKatas.Katas.TcpStateMachine.Interfaces;

namespace CodeKatas.Katas.TcpStateMachine
{
    public class LastAckState : IState
    {
        public string Value => "LAST_ACK";
        
        public IState Transition(string @event)
        {
            // LAST_ACK: RCV_ACK -> CLOSED
            if (@event == TcpEvents.RcvAck)
            {
                return new ClosedState();
            }

            return new ErrorState();
        }
    }
}
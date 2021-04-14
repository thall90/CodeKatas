using CodeKatas.Katas.TcpStateMachine.Interfaces;

namespace CodeKatas.Katas.TcpStateMachine
{
    public class SynSentState : IState
    {
        public string Value => "SYN_SENT";
        
        public IState Transition(string @event)
        {
            // SYN_SENT: RCV_SYN -> SYN_RCVD
            if (@event == TcpEvents.RcvSyn)
            {
                return new SynRcvdState();
            }
            
            // SYN_SENT: RCV_SYN_ACK -> ESTABLISHED
            if (@event == TcpEvents.RcvSynAck)
            {
                return new EstablishedState();
            }
            
            // SYN_SENT: APP_CLOSE -> CLOSED
            if (@event == TcpEvents.AppClose)
            {
                return new ClosedState();
            }
            
            return new ErrorState();
        }
    }
}
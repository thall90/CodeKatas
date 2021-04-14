using CodeKatas.Katas.TcpStateMachine.Interfaces;

namespace CodeKatas.Katas.TcpStateMachine
{
    public class SynRcvdState : IState
    {
        public string Value => "SYN_RCVD";
        
        public IState Transition(string @event)
        {
            // SYN_RCVD: APP_CLOSE -> FIN_WAIT_1
            if (@event == TcpEvents.AppClose)
            {
                return new FinWaitOneState();
            }
            
            // SYN_RCVD: RCV_ACK -> ESTABLISHED
            if (@event == TcpEvents.RcvAck)
            {
                return new EstablishedState();
            }
            
            return new ErrorState();
        }
    }
}
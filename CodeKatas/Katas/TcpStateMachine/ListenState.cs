using CodeKatas.Katas.TcpStateMachine.Interfaces;

namespace CodeKatas.Katas.TcpStateMachine
{
    public class ListenState : IState
    {
        public string Value => "LISTEN";
        
        public IState Transition(string @event)
        {
            //LISTEN: RCV_SYN -> SYN_RCVD
            if (@event == TcpEvents.RcvSyn)
            {
                return new SynRcvdState();
            }
            
            // LISTEN: APP_SEND -> SYN_SENT
            if (@event == TcpEvents.AppSend)
            {
                return new SynSentState();
            }
            
            // LISTEN: APP_CLOSE -> CLOSED
            if (@event == TcpEvents.AppClose)
            {
                return new ClosedState();
            }
            
            return new ErrorState();
        }
    }
}
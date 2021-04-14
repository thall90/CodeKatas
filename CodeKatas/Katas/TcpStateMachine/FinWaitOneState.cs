using System.Collections.Generic;
using CodeKatas.Katas.TcpStateMachine.Interfaces;

namespace CodeKatas.Katas.TcpStateMachine
{
    public class FinWaitOneState : IState
    {
        public string Value => "FIN_WAIT_1";
        
        public IState Transition(string @event)
        {
            // FIN_WAIT_1: RCV_FIN -> CLOSING
            if (@event == TcpEvents.RcvFin)
            {
                return new ClosingState();
            }
            
            
            // FIN_WAIT_1: RCV_FIN_ACK -> TIME_WAIT
            if (@event == TcpEvents.RcvFinAck)
            {
                return new TimeWaitState();
            }
            
            // FIN_WAIT_1: RCV_ACK -> FIN_WAIT_2
            if (@event == TcpEvents.RcvAck)
            {
                return new FinWaitTwoState();
            }
            
            return new ErrorState();
        }
    }
}
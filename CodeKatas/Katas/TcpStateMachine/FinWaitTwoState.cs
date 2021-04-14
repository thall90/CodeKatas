using CodeKatas.Katas.TcpStateMachine.Interfaces;

namespace CodeKatas.Katas.TcpStateMachine
{
    public class FinWaitTwoState : IState
    {
        public string Value => "FIN_WAIT_2";
        
        public IState Transition(string @event)
        {
            // FIN_WAIT_2: RCV_FIN -> TIME_WAIT
            if (@event == TcpEvents.RcvFin)
            {
                return new TimeWaitState();
            }

            return new ErrorState();
        }
    }
}
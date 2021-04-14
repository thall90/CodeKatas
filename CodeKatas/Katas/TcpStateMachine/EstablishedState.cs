using CodeKatas.Katas.TcpStateMachine.Interfaces;

namespace CodeKatas.Katas.TcpStateMachine
{
    public class EstablishedState : IState
    {
        public string Value => "ESTABLISHED";
        
        public IState Transition(string @event)
        {
            // ESTABLISHED: APP_CLOSE -> FIN_WAIT_1
            if (@event == TcpEvents.AppClose)
            {
                return new FinWaitOneState();
            }
            
            // ESTABLISHED: RCV_FIN -> CLOSE_WAIT
            if (@event == TcpEvents.RcvFin)
            {
                return new CloseWaitState();
            }
            
            return new ErrorState();
        }
    }
}
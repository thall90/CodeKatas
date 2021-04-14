using CodeKatas.Katas.TcpStateMachine.Interfaces;

namespace CodeKatas.Katas.TcpStateMachine
{
    public class TimeWaitState : IState
    {
        public string Value => "TIME_WAIT";
        
        public IState Transition(string @event)
        {
            // TIME_WAIT: APP_TIMEOUT -> CLOSED
            if (@event == TcpEvents.AppTimeout)
            {
                return new ClosedState();
            }

            return new ErrorState();
        }
    }
}
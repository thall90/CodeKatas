using System.Linq;
using CodeKatas.Katas.TcpStateMachine.Interfaces;

namespace CodeKatas.Katas.TcpStateMachine
{
    public class TCP
    {
        public static string TraverseStates(string[] events)
        {
            IState state = new ClosedState();
            var enumerator = events.AsEnumerable().GetEnumerator();

            while (enumerator.MoveNext() && state.Value != "ERROR")
            {
                state = state.Transition(enumerator.Current);
            }
            
            return state.Value;
        }
    }
}
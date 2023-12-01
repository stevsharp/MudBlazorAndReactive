using MudBlazorTemplates1.Client.Actions;
using MudBlazorTemplates1.Client.States;

using System.Reactive.Subjects;

namespace MudBlazorTemplates1.Client.StateStores
{
    public class CounterStateStore :
  StateStoreBase<CounterState>, ICounterStateStoreActions
    {
        public CounterStateStore() : base()
        {
            CounterState initialState = new CounterState(0);
            state = new BehaviorSubject<CounterState>(initialState);
        }
        public void Increment()
        {
            var nextState = state.Value with { counter = state.Value.counter + 1 };
            state.OnNext(nextState);
        }
    }
}

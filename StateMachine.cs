public class StateMachine<T>
{
    private T owner;
    private IState<T> currentState;
    private IState<T> previousState;

    public StateMachine(T owner)
    {
        this.owner = owner;
    }

    public void ChangeState(IState<T> newState)
    {
        previousState = currentState;
        if (currentState != null)
        {
            currentState.Exit(owner);
        }


        currentState = newState;

        if (currentState != null)
        {
            currentState.Enter(owner);
        }

    }

    public void Update()
    {
        if (currentState != null)
        {
            currentState.Execute(owner);
        }
    }

    public void RevertToPreviousState()
    {
        ChangeState(previousState);
    }
}

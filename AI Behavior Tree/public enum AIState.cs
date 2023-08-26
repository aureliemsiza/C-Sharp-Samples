public enum AIState
{
    Idle,
    Patrol,
    Chase,
    Attack
}

public class AIBehaviorTree : MonoBehaviour
{
    private AIState currentState = AIState.Idle;

    private void Update()
    {
        switch (currentState)
        {
            case AIState.Idle:
                // Implement idle behavior
                break;

            case AIState.Patrol:
                // Implement patrol behavior
                break;

            case AIState.Chase:
                // Implement chase behavior
                break;

            case AIState.Attack:
                // Implement attack behavior
                break;
        }
    }

    void ChangeState(AIState newState)
    {
        currentState = newState;
        // Handle state entry and exit logic here
    }
}

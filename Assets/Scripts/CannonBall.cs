using UnityEngine;

public class CannonBall : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;
    
    public void Fire(float force)
    {
        rb.AddForce(rb.transform.forward * force, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Goal"))
        {
            other.gameObject.GetComponent<Goal>().IncreasePoint();
        }

        if (!GoalManager.Instance.IsWin && CannonBallManager.Instance.Quantity <= 0)
        {
            StateManager.Instance.Lose();
        }
        Destroy(gameObject);
    }
    
}

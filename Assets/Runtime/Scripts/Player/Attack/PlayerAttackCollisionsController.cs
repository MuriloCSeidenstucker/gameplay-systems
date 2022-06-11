using UnityEngine;

public class PlayerAttackCollisionsController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        print(otherCollider.gameObject.name);
    }
}

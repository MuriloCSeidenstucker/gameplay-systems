using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 10.0f;
    [SerializeField] private float movementAcc = 100.0f;

    private Rigidbody2D _rigidbody;
    private Vector2 _currentVelocity;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Vector2 previousPosition = _rigidbody.position;
        Vector2 currentPosition = previousPosition + _currentVelocity * Time.fixedDeltaTime;
        _rigidbody.MovePosition(currentPosition);
    }

    public void ProcessMovementInput(Vector2 movementInput)
    {
        Vector2 desiredSpeed = movementInput * movementSpeed;
        _currentVelocity = Vector2.MoveTowards(_currentVelocity, desiredSpeed, movementAcc * Time.deltaTime);
    }
}

using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerController : MonoBehaviour
{
    private CharacterMovement _charMovement;

    private void Awake()
    {
        _charMovement = GetComponent<CharacterMovement>();
    }

    private void Update()
    {
        float horizontalInput = CrossPlatformInputManager.GetAxisRaw("Horizontal");
        float verticalInput = CrossPlatformInputManager.GetAxisRaw("Vertical");
        Vector2 movementInput = new Vector2(horizontalInput, verticalInput);

        _charMovement.ProcessMovementInput(movementInput);
    }
}

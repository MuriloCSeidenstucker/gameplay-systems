using System.Collections;
using UnityEngine;

public class PlayerAttackController : MonoBehaviour
{
    private BoxCollider2D _playerAttackCollider;

    [Range(0f, 3f)]
    [SerializeField] private float _playerAttackDelay;

    private bool _playerIsAttacking;

    private void Awake()
    {
        _playerAttackCollider = GetComponent<BoxCollider2D>();    
    }

    private IEnumerator PlayerAttack()
    {
        _playerIsAttacking = true;
        _playerAttackCollider.enabled = true;
        _playerAttackCollider.isTrigger = true;

        yield return new WaitForSeconds(_playerAttackDelay);

        _playerIsAttacking = false;
        _playerAttackCollider.enabled = false;
        _playerAttackCollider.isTrigger = false;
    }

    public void CheckIfPlayerCanAttackAndCallPlayerAttackCoroutine()
    {
        if (!_playerIsAttacking)
        {
            StartCoroutine(PlayerAttack());
        }
    }

}

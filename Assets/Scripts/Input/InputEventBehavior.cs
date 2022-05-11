using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputEventBehavior : MonoBehaviour
{
    private PlayerMovementBehaviour _playerMovement;
    [SerializeField]
    private ProjectileSpawnerBehaviour _gun;

    private void Start()
    {
        _playerMovement = GetComponent<PlayerMovementBehaviour>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        _playerMovement.Move(context.ReadValue<Vector2>());
    }

    public void OnFire(InputAction.CallbackContext context)
    {
        _gun.Fire();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputDelagateBehavior : MonoBehaviour
{
    private PlayerControls _playerControls;
    private PlayerMovementBehaviour _playerMovement;
    [SerializeField]
    private ProjectileSpawnerBehaviour _gun;

    private void Awake()
    {
        _playerControls = new PlayerControls();
        _playerMovement = GetComponent<PlayerMovementBehaviour>();
    }

    private void OnEnable()
    {
        _playerControls.Enable();
    }

    private void OnDisable()
    {
        _playerControls.Disable();
    }

    private void Start()
    {
        _playerControls.Ship.Shoot.performed += context => _gun.Fire();
    }

    private void FixedUpdate()
    {
        Vector2 moveDir = _playerControls.Ship.Movement.ReadValue<Vector2>();
        _playerMovement.Move(moveDir);
    }
}

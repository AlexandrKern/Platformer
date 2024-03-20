using UnityEngine;

[RequireComponent (typeof(PlayerMovement))]
[RequireComponent(typeof(Fighter))]
public class PlayerInput : MonoBehaviour
{
    private PlayerMovement _movement;
    private Fighter _fighter;

    private float _horizontalDirection;
    private bool _isJumpButtonPressed;
    private bool _isHitButtonPressed;

    private void Start()
    {
        _fighter = GetComponent<Fighter>();
        _movement = GetComponent<PlayerMovement>();
    }

    private void Update()
    {
       GettingData();
    }

    private void GettingData()
    {
        _horizontalDirection = Input.GetAxisRaw(GlobalStringVars.HORIZONTAL_AXIS);
        _isJumpButtonPressed = Input.GetButtonDown(GlobalStringVars.JUMP);
        _isHitButtonPressed = Input.GetButtonDown(GlobalStringVars.FIGHT);
        _movement.Move(_horizontalDirection, _isJumpButtonPressed);
        _fighter.Hit(_isHitButtonPressed);
    }
}

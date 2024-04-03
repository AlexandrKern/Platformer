using UnityEngine;

[RequireComponent (typeof(AnimationController))]
[RequireComponent (typeof(Rigidbody2D))]
[RequireComponent(typeof(Health))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _jumpForce;
    [SerializeField] private Transform _groundColliderTransform;
    [SerializeField] private LayerMask _groundLayerMask;
    [SerializeField] private float _radius;
    [SerializeField] private float _speedMovement;

    private bool _isGrounded;
    private AnimationController _animationController;
    private Vector2 _ovetlapCirclePosition;
    private Rigidbody2D _knightRigidbody;
    private Quaternion _rotate;

    private Health _health;



    private void Start()
    {
        _health = GetComponent<Health> ();
        _animationController = GetComponent<AnimationController>();
        _knightRigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        CheckIsGrounded();
    }

    private void CheckIsGrounded()
    {
        _ovetlapCirclePosition = _groundColliderTransform.position;
        _isGrounded = Physics2D.OverlapCircle(_ovetlapCirclePosition, _radius, _groundLayerMask);
    }

    public void Move(float direction, bool _IsJumpButtonPressed)
    {
        
        if ((!_health.CheckIsAlive()&&Finish.Finished)&&StopKnight.Go)
        {       
            if (_IsJumpButtonPressed)
            {
                Jump();
            }
            if (direction != 0)
            {
                RotateKnight(direction);
                _animationController.KnightRunOnAnimation();
                HorizontalMovement(direction);
            }
            else
            {
                _animationController.KnightIdleOnAnimation();
            }
        }
    }

    private void Jump()
    {
        if (_isGrounded)
        {
            _knightRigidbody.velocity = new Vector2(_knightRigidbody.velocity.x, _jumpForce);
        }
    }

    private void HorizontalMovement(float direction)
    {
        _knightRigidbody.velocity = new Vector2(direction * _speedMovement,_knightRigidbody.velocity.y);
    }

    private void RotateKnight(float direction)
    {
        if (direction > 0)
        {
            _rotate = transform.rotation;
            _rotate.y = 0;
            transform.rotation = _rotate;
        }
        if (direction < 0)
        {
            _rotate = transform.rotation;
            _rotate.y = 180;
            transform.rotation = _rotate;
        }
    }
}

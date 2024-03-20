using UnityEngine;

public class PltformController : MonoBehaviour
{
    [SerializeField] private SliderJoint2D _platform;

    private JointMotor2D _motor;
    private bool _isPlatformRotation;

    void Start()
    {
        _motor = _platform.motor;
        _isPlatformRotation = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Rotation(collision);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        Transports(collision);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        collision.transform.parent = null;
    }

    private void Rotation(Collider2D collision)
    {
        if (_isPlatformRotation)
        {
            _motor.motorSpeed = 1;
        }
        else
        {
            _motor.motorSpeed = -1;
        }

        if (collision.CompareTag("RotationPlatform"))
        {
            _platform.motor = _motor;
            _isPlatformRotation = !_isPlatformRotation;
        }
    }

    private void Transports(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.parent = transform;
            
        }
    }
}

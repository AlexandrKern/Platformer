using UnityEngine;

public class PltformController : MonoBehaviour
{
    [SerializeField] private SliderJoint2D _platform;
    [SerializeField] private float _speed;

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

    private void Rotation(Collider2D collision)
    {
        if (_isPlatformRotation)
        {
            _motor.motorSpeed = _speed;
        }
        else
        {
            _motor.motorSpeed = -_speed;
        }

        if (collision.CompareTag("RotationPlatform"))
        {
            _platform.motor = _motor;
            _isPlatformRotation = !_isPlatformRotation;
        }
    }
}

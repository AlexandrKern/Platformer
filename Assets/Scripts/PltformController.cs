using System.Collections;
using System.Collections.Generic;
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
}

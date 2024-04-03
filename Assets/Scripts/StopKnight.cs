using UnityEngine;

public class StopKnight : MonoBehaviour
{
    private float _currentTime;
    public static bool Go;

    private void Start()
    {
        Go = false;
        _currentTime = 10;
    }

    private void Update()
    {
        _currentTime -= Time.deltaTime;
        if (_currentTime <=0)
        {
            Go = true;
        }
    }
}

using UnityEngine;

public class ParallaxController : MonoBehaviour
{
    [SerializeField] private Transform[] _backGrounds;
    [SerializeField] private float[] _ratios;

    private float _quantityGrounds;

    void Start()
    {
        _quantityGrounds = _backGrounds.Length;
    }

    void Update()
    {
        for (int i = 0; i < _quantityGrounds; i++)
        {
            _backGrounds[i].position = transform.position * _ratios[i];
        }
    }
}

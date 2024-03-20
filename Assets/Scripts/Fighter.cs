using UnityEngine;

[RequireComponent (typeof(AnimationController))]
public class Fighter : MonoBehaviour
{
    [SerializeField] private GameObject _weapon;
    private AnimationController _animationController;

    private void Start()
    {
        _animationController = GetComponent<AnimationController>();
    }

    public void Hit(bool _isHitButtonPressed)
    {
        if (_isHitButtonPressed)
        {
            _animationController.KnightAttackOnAnimation();
            _weapon.transform.localPosition = new Vector2(0.3f, 0);
        }
        else
        {
            _weapon.transform.localPosition = Vector3.zero;
        }
    }
}
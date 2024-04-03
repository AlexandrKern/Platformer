using UnityEngine;

[RequireComponent (typeof(AnimationController))]
public class Fighter : MonoBehaviour
{
    [SerializeField] private GameObject _weapon;
    [SerializeField] private LayerMask _enemyLayers;
    [SerializeField] private float _damage;

    private Collider2D[] _hitEnemies;
    private AnimationController _animationController;
    private Health _health;

    private void Start()
    {
        _animationController = GetComponent<AnimationController>();
    }

    public void Hit(bool _isHitButtonPressed)
    {
        if (_isHitButtonPressed)
        {
            _animationController.KnightAttackOnAnimation();
            _hitEnemies = Physics2D.OverlapCircleAll(_weapon.transform.position, 0.5f, _enemyLayers);
            foreach (Collider2D enemy in _hitEnemies)
            {
                _health = enemy.GetComponent<Health>();
                if (_health != null)
                {
                    _health.TakeDamage(_damage);
                }
            }
        }
    }
}

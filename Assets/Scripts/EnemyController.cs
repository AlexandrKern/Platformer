using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private float _speed,_timeToRevert;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private Animator _animator;

    private Rigidbody2D _enemyRigidbody;

    private const float IDLE_STATE = 0;
    private const float WALK_STATE = 1;
    private const float REVERT_STATE = 2;

    private float _currentState,_currentTimeToRevert;

    void Start()
    {
        _currentTimeToRevert = 0;
        _currentState = WALK_STATE;
        _enemyRigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        EnemyMovement();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ChangeState(collision);
    }

    private void EnemyMovement()
    {
        if (_currentTimeToRevert >= _timeToRevert)
        {
            _currentTimeToRevert = 0;
            _currentState = REVERT_STATE;
        }

        switch (_currentState)
        {
             case IDLE_STATE:
                _currentTimeToRevert += Time.deltaTime;
             break;
             case WALK_STATE:
                _enemyRigidbody.velocity = Vector3.left * _speed;
             break;
             case REVERT_STATE:
                _spriteRenderer.flipX = !_spriteRenderer.flipX;
                _speed *= -1;
                _currentState = WALK_STATE;
             break;
        }

        _animator.SetFloat("Velosity",_enemyRigidbody.velocity.magnitude);
    }

    private void ChangeState(Collider2D collision)
    {
        if (collision.CompareTag("Stopper"))
        {
            _currentState = IDLE_STATE;
        }
    }
}

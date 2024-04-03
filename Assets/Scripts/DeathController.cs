using System.Collections;
using UnityEngine;

[RequireComponent(typeof(AnimationController))]
[RequireComponent(typeof(Health))]
[RequireComponent(typeof(Rigidbody2D))]
public class DeathController : MonoBehaviour
{
    [SerializeField] private GameObject _deathPanel;

    private Health _health;
    private AnimationController _animationController;

    private void Start()
    {
        _health = GetComponent<Health>();
        _animationController = GetComponent<AnimationController>();
    }

    private void Update()
    {
        Death();
    }

    private void Death()
    {
        if (CompareTag("Player"))
        {
            if (_health.CheckIsAlive())
            {
                _animationController.KnightDeathOnAnimation();
                _deathPanel.SetActive(true);
            }
        }
        if (CompareTag("Enemy"))
        {
            if (_health.CheckIsAlive())
            {
                _animationController.SkeletonDeathOnAnimation();
                StartCoroutine(TimerEnemyDeath());
            }
        }
    }

    private IEnumerator TimerEnemyDeath()
    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
        ScoreText.Score += 50;
    }
}


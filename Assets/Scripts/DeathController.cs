using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(AnimationController))]
[RequireComponent (typeof(Health))]
public class DeathController : MonoBehaviour
{
    [SerializeField] private GameObject _deathCanvas;
    [SerializeField] private Text _healthText;

    private Health _health;
    private AnimationController _animationController;

    private void Start()
    {
        _animationController = GetComponent<AnimationController>();
        _health = GetComponent<Health>();
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
                _healthText.text = $"HP {_health.GetHealth()}";
                StartCoroutine(TimerLoadScene());
                _deathCanvas.SetActive(true);
            }
            else
            {
                _healthText.text = $"HP {_health.GetHealth()}";
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

    private IEnumerator TimerLoadScene()
    {
        yield return new WaitForSeconds(1);

        _deathCanvas.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private IEnumerator TimerEnemyDeath()
    {
        yield return new WaitForSeconds(1);

        Destroy(gameObject);
    }
}

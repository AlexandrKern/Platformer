using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] private Text _currentHealthText;
    [SerializeField] private float _maxHealth;
    private float _currentHealth;

    private void Start()
    {
        _currentHealth = _maxHealth;
    }

    private void Update()
    {
        PrintHealth();
    }

    public void TakeDamage(float damage)
    {
        _currentHealth -= damage;
    }

    public bool CheckIsAlive()
    {
        if (_currentHealth <= 0) 
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void PrintHealth()
    {
        if (_currentHealthText != null)
        {
            _currentHealthText.text = $"HP {_currentHealth}";
        }
    }
}

using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float _maxHealth;
    private float _currentHealth;

    private void Start()
    {
        _currentHealth = _maxHealth;
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

    public float GetHealth()
    {
        return _currentHealth;
    }
}

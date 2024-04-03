using UnityEngine;

public class Damage : MonoBehaviour
{
    [SerializeField] private float _damage;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        DealDamage(collision, "Player");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        DealDamage(collision, "Player");
        DealDamage(collision, "Enemy");
    }

    private void DealDamage(Collider2D collision, string damageReceiverName)
    {
        if (collision.gameObject.CompareTag(damageReceiverName))
        {
            collision.gameObject.GetComponent<Health>().TakeDamage(_damage);
        }
    }

    private void DealDamage(Collision2D collision, string damageReceiverName)
    {
        if (collision.gameObject.CompareTag(damageReceiverName))
        {
            collision.gameObject.GetComponent<Health>().TakeDamage(_damage);
        }
    }
}

using UnityEngine;

public class GamePoints : MonoBehaviour
{
    [SerializeField] private int _valuePoints;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Collect(collision);
    }

    private void Collect(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
           ScoreText.Score += _valuePoints;
            Destroy(gameObject);
        }
    }
}

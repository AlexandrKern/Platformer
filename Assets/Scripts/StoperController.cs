using System.Collections;
using UnityEngine;

public class StoperController : MonoBehaviour
{
    [SerializeField] private float _delay;
    [SerializeField] private GameObject _stoper;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StartCoroutine(TurnOnTheMace());
        }
    }

    private IEnumerator TurnOnTheMace()
    {
        yield return new WaitForSeconds(_delay);
        _stoper.SetActive(false);
    }
}

using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    [SerializeField] private GameObject _finishCanvas;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _finishCanvas.SetActive(true);
            StartCoroutine(TimerLoadScene());
        }
    }
    private IEnumerator TimerLoadScene()
    {
        yield return new WaitForSeconds(1);

        _finishCanvas.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

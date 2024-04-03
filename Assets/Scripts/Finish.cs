using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField] private GameObject _finishPanel;
    public static bool Finished;

    private void Start()
    {
        Finished = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Finished = false;
            _finishPanel.SetActive(true);
        }
    }
}

using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    [SerializeField] private Text _currentPoinsScoreText;
    [SerializeField] private Text _deathPoinsScoreText;
    [SerializeField] private Text _finishPoinsScoreText;

    public static int Score;

    private void Start()
    {
        Score = 0;
    }

    void Update()
    {
        Print();
    }

    private void Print()
    {
        if ((_currentPoinsScoreText!=null&& _deathPoinsScoreText!=null)&& _finishPoinsScoreText!=null)
        {
            _currentPoinsScoreText.text = $"Scocre {Score}";
            _deathPoinsScoreText.text = $"Scocre {Score}";
            _finishPoinsScoreText.text = $"Scocre {Score}";
        }
    }
}

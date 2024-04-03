using UnityEngine;

public class MenuController : MonoBehaviour
{
    [SerializeField] private GameObject _screen;
    private GameObject _currentScreen;

    void Start()
    {
        _currentScreen = _screen;
        _currentScreen.SetActive(true);
    }

    public void ChangeScreen(GameObject screen)
    {
        _currentScreen.SetActive(false);
        screen.SetActive(true);
        _currentScreen = screen;
    }
}

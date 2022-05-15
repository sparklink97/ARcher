using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverPanel : MonoBehaviour
{
    
    [SerializeField]
    private Button exitButton;
    [SerializeField]
    private Button restartButton;

    private void Start()
    {
        exitButton.onClick.AddListener(ExitGame);
        restartButton.onClick.AddListener(Restart);
    }

    private void ExitGame()
    {
        Application.Quit();
    }
    private void Restart()
    {
        SceneManager.LoadScene(0);
    }
    
}

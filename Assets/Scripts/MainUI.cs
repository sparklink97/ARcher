using UnityEngine;
using UnityEngine.UI;

public class MainUI : MonoBehaviour
{
    [SerializeField]
    private PauseMenu pauseMenu;
    [SerializeField]
    private Button button;
    [SerializeField]
    private GameManager gameManager;
    [SerializeField]
    private Slider slider;
    
    

    private void Start()
    {
        button.onClick.AddListener(OpenPauseMenu);
        slider.value = slider.maxValue;
    }

    private void OpenPauseMenu()
    {
       gameManager.StopGame(pauseMenu.gameObject);
    }
}

using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{

   [SerializeField]
   private Button returnButton;
   [SerializeField]
   private Button exitButton;
   [SerializeField]
   private GameManager gameManager;
   
   
   private void Start()
   {
      returnButton.onClick.AddListener(Return);
      exitButton.onClick.AddListener(ExitGame);
   }

   private void ExitGame()
   {
      Application.Quit();
   }

   private void Return()
   {
    gameManager.BackToGame(gameObject);  
   }
}

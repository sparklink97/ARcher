using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class GameManager : MonoBehaviour
{

    [SerializeField]
    private SpawnTargets spawnTargets;
    [SerializeField]
    private ARTrackedImageManager manager;
    [SerializeField]
    private PauseMenu pauseMenu;
    [SerializeField]
    private MainUI mainUI;
    [SerializeField]
    private GameOverPanel gameOverPanel;
    [SerializeField]
    private PointsManager pointsManager;
    [SerializeField]
    private TMP_Text scoreText;
    [SerializeField]
    private TMP_Text infoText;
    [SerializeField]
    private ARSession arSession;
    


    private void Awake()
    {
        arSession.Reset();
        Time.timeScale = 1;
        mainUI.gameObject.SetActive(true);
        pauseMenu.gameObject.SetActive(false);
        gameOverPanel.gameObject.SetActive(false);
        spawnTargets.isReady = false;
        pointsManager.readyToStart = false;
        infoText.gameObject.SetActive(true);
    }

    private void Update()
    {
        if (manager.trackables.count == 1)
        {
            spawnTargets.isReady = true;
            pointsManager.readyToStart = true;
            infoText.gameObject.SetActive(false);
        }
    }

    public void StopGame(GameObject panel)
    {
        mainUI.gameObject.SetActive(false);
        Time.timeScale = 0;
        panel.SetActive(true);
    }

    public void BackToGame(GameObject panel) {
        panel.SetActive(false);
        mainUI.gameObject.SetActive(true);
        Time.timeScale = 1;
    }

    public void EndGame()
    {
        scoreText.text = pointsManager.GetScore().ToString();
        StopGame(gameOverPanel.gameObject);
    }
}

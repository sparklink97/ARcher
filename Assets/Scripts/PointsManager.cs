using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PointsManager : MonoBehaviour
{

    [SerializeField]
    private TMP_Text scoreText;
    [SerializeField]
    private Slider timer;
    [SerializeField]
    private GameManager gameManager;

    private string pointsTEXT = "Points: ";
    private int score;
    public bool readyToStart;

    private void Start()
    {
        scoreText.text = pointsTEXT + "0";
        timer.value = timer.maxValue;
    }

    private void Update()
    {
        if (!readyToStart)
        {
            return;
        }
        
        timer.value -= Time.deltaTime;

        if (timer.value <= timer.minValue)
        {
            readyToStart = false;
            gameManager.EndGame();
        }
    }

    public void UpdateScore()
    {
        score++;
        scoreText.text = pointsTEXT + score;
        UpdateTimer();
    }

    private void UpdateTimer()
    {
        if (timer.value + 2 > timer.maxValue)
        {
            timer.value = timer.maxValue;
        }
        else
        {
            timer.value += 2;
        }
    }

    public int GetScore()
    {
        return score;
    }
}

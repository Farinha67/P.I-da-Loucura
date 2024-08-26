using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Timer1 : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField]float remainingTime;
    public GameManangerScript gameMananger;
    public GameObject Player;
    // Update is called once per frame
    void Update()
    {
        if (remainingTime > 0)
        {

            remainingTime -= Time.deltaTime;
        }
        else if (remainingTime < 0)
        {
            remainingTime = 0;
            gameMananger.GameOver();
            timerText.color = Color.red;
            Destroy(Player);
        }
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    public void Pause()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0;

    }
    public void Resume()
    {

        PauseMenu.SetActive(false);
        Time.timeScale = 1;

    }
}

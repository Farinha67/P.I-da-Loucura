using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    public Image endGameImage;
    public Player player;

    void Start()
    {
     
        endGameImage.gameObject.SetActive(false);
    }

    
    public void ShowEndGameImage()
    {
        endGameImage.gameObject.SetActive(true);
    }

    void Update()
    {
        if (player.score>=10)
        {
            ShowEndGameImage();
        }
    }
    public void Next()
    {
        SceneManager.LoadScene("Biblioteca");
    }
}

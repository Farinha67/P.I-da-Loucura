using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next : MonoBehaviour
{
    [SerializeField] private string NomeDoLevelDeJogo;
    public void next()
    {
        SceneManager.LoadScene(NomeDoLevelDeJogo);
    }
}

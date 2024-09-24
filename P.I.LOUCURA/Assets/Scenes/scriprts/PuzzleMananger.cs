using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PuzzleMananger : MonoBehaviour
{
    public PieceDrag[] pieces; // Referência para todas as peças
    public string nextSceneName; // Nome da cena para trocar
    public Button nextButton; // Referência para o botão que aparece quando as peças estiverem encaixadas

    void Start()
    {
        // Esconde o botão no início
        nextButton.gameObject.SetActive(false);
    }
    
    void Update()
    {
        CheckAllPieces();
    }

    void CheckAllPieces()
    {
        // Verifica se todas as peças estão encaixadas corretamente
        foreach (PieceDrag piece in pieces)
        {
            if (Vector3.Distance(piece.transform.position, piece.targetPosition.position) > piece.snapDistance)
            {
                return; // Se alguma peça não estiver encaixada, sai da função
            }
        }

        // Se todas as peças estão encaixadas, mostra o botão
        ShowNextButton();
    }

    void ShowNextButton()
    {
        // Ativa o botão
        nextButton.gameObject.SetActive(true);
    }
    public void NextButton()
    {

        SceneManager.LoadScene("Final");
    }
}
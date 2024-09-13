using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceDrag : MonoBehaviour
{
    private Vector3 offset;
    private Camera mainCamera;

    public Transform targetPosition; // Define a posição de encaixe no Inspector
    public float moveSpeed = 10f; // Velocidade de movimentação para a posição de encaixe
    public float snapDistance = 0.5f; // Distância mínima para encaixar a peça automaticamente

    void Start()
    {
        mainCamera = Camera.main;
    }

    void OnMouseDown()
    {
        Vector3 mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        offset = transform.position - mousePosition;
    }

    void OnMouseDrag()
    {
        Vector3 mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        transform.position = mousePosition + offset;
    }

    void OnMouseUp()
    {
        // Verifica se a peça está dentro da distância mínima para encaixar
        if (Vector3.Distance(transform.position, targetPosition.position) <= snapDistance)
        {
            // Move diretamente para a posição do alvo
            transform.position = targetPosition.position;
        }
    }
}

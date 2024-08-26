using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage = 1;
    // Start is called before the first frame update
    void Start()
    {
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Enemy enemy = collision.GetComponent<Enemy>();
            
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject, 1.0f);
    }
    private void OnBecameVisible()
    {
    }

}

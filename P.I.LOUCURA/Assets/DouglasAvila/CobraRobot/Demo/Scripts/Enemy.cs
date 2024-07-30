using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject itemPrefab;
    public int life = 2;
    public int damage = 2;


    // Start is called before the first frame update

    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {//Aqui o collision representa o Bullet


            life -= collision.gameObject.GetComponent<Bullet>().damage;
            Destroy(collision.gameObject);//Esse destroi o tiro
            if (life <= 0)
            {
                Destroy(gameObject);//Esse destroi o inimigo
            }
            if (life < 0)
            {
                Instantiate(gameObject).GetComponent<DroparItem>();
            }

        }
    }
    public void Destruir()
    {
        ControladorDePontuação.Pontuacao++;
        Destroy(this.gameObject);
    }
    void OnDestroy()
    {
        if (itemPrefab != null)
        {
            Instantiate(itemPrefab, transform.position, Quaternion.identity);
        }
    }
}


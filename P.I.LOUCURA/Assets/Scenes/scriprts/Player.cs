using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int life = 3;
    public int lifeMax;
    public GameObject bullet;
    public Transform foot;
    bool groundCheck;
    public float speed = 5, jumpStrength = 5, bulletSpeed = 8;
    float horizontal;
    public Rigidbody2D body;
    public Animator animator;

    public int direction = 1;
    public int score;
    public Text texto;
    public string text;
    [SerializeField] private Bullet bulletprefab;
    // Start is called before the first frame update
    void Start()
    {
        lifeMax = life;



    }

    // Update is called once per frame
    void Update()
    {
     







        texto.text = "Pontos :" + score.ToString();

        horizontal = Input.GetAxisRaw("Horizontal");
        body.velocity = new Vector2(horizontal * speed, body.velocity.y);
        animator.SetFloat("Speed",horizontal);
        groundCheck = Physics2D.OverlapCircle(foot.position, 0.05f);

        if (Input.GetButtonDown("Jump") && groundCheck)
        {
            body.AddForce(new Vector2(0, jumpStrength * 100));
        }
        if (horizontal != 0)//Para GetAxisRaw
        {
            direction = (int)horizontal;
        }
        /*Para quem está usando GetAxis
        if(horizontal < 0)
        {
            direction = -1;
        } else if(horizontal > 0)
        {
            direction = 1;
        }
        */
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject temp = Instantiate(bullet, transform.position, transform.rotation);  
            temp.GetComponent<Rigidbody2D>().velocity = new Vector2(bulletSpeed * direction, 0);
        }
        UpdateScoreText();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            //life--;
            //life -= 1;
            //life = life -1;
           
            if (life <= 0)
            {
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.CompareTag("Aumenta"))
        {
            score += 4;
            Destroy(collision.gameObject);
            UpdateScoreText();
        }
        if (collision.gameObject.CompareTag("Divide"))
        {
            score = score / 2;
            Destroy(collision.gameObject);
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
    }
    private void UpdateScoreText()
    {
    }
}
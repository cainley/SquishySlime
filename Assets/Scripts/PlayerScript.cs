using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Rigidbody2D rb;
    Animator anim;
    SpriteRenderer sprite;
    public float speed = 12.5f;
    bool isGrounded;
    private bool isDead;
    public GameManagerScript gameManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isGrounded = true;
        isDead = false;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isDead)
        {
            if (Input.GetKey(KeyCode.Space) && isGrounded)
            {
                rb.linearVelocity = new Vector2(0, 12.50f);
                anim.SetTrigger("JumpTrigger");
                isGrounded = false;
            }

            //move left and right
            if (Input.GetKey(KeyCode.A))
            {
                rb.linearVelocity = new Vector2(-speed, rb.linearVelocity.y);
                sprite.flipX = true;
            }
            else if (Input.GetKey(KeyCode.D))
            {
                rb.linearVelocity = new Vector2(speed, rb.linearVelocity.y);
                sprite.flipX = false;
            }
            else
            {
                rb.linearVelocity = new Vector2(0, rb.linearVelocity.y);
            }
            
            //anim.SetFloat("RunSpeed", Mathf.Abs(rb.linearVelocity.x));

            //Mechanic (Squishing the Slime)
            if (Input.GetKeyDown(KeyCode.W))
            {
                transform.localScale = new Vector3(1f, 3f, 3f);
                //anim.SetTrigger("SquishUp");
                anim.SetBool("SquishUp", true);
            }
            if (Input.GetKeyUp(KeyCode.W))
            {
                transform.localScale = new Vector3(3f, 3f, 3f);
                anim.SetBool("SquishUp", false);
            }
            if (Input.GetKeyDown(KeyCode.S))
                //anim.SetBool("SquishDown", true);
            {
                transform.localScale = new Vector3(3f, 1f, 3f);
            }
            if (Input.GetKeyUp(KeyCode.S))
            {
                transform.localScale = new Vector3(3f, 3f, 3f);
                anim.SetBool("SquishDown", false);
            }
            /*
            if (Input.GetKeyDown(KeyCode.R))
            {
                gameManager.gameOver();
            }
            else
            {
                
            }
            */
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Floor" && isGrounded == false)
        {
            isGrounded = true;
        }

        if (other.gameObject.tag == "Death" && !isDead)
        {
            isDead = true;
            gameManager.gameOver();
            anim.SetTrigger("DeathTrigger");
        }
    }
}

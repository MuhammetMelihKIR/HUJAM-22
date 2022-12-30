using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yeni : MonoBehaviour
{
    Rigidbody2D rb;
    PlayerSwitch ps;
    Animator anim;
    [SerializeField] float moveSpeed = 2f;
    [SerializeField] float jumpPower = 5f;
    bool canJump = true;
    public GameObject littlePlayer;
    public GameObject bullet;
    public Transform firePoint;
    float timeBetween;
    public float startTimeBetween;
    public static bool rightOn;
    public static bool leftOn;
    public GameObject tp8;

    void Awake()
    {
        rightOn = true;
        leftOn=false;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        ps = GameObject.Find("Player Switcher").GetComponent<PlayerSwitch>();
    }

    private void Update()
    {
        if(ps.activePlayer == this.gameObject)
        {
            PlayerInputs();

            if (timeBetween <= 0 && (Input.GetKeyDown(KeyCode.Mouse0)))
            {
                AudioManager.instance.shootFX();
                Instantiate(bullet, firePoint.position, firePoint.rotation);
                timeBetween = startTimeBetween;
            }
            else
            {
                timeBetween -= Time.deltaTime;
            }
           


        }
        
    }
    void PlayerInputs()
    {
        if(Input.GetKey(KeyCode.D))
        {
            MoveRight();
            rightOn = true;
            leftOn = false;
        }
        if(Input.GetKey(KeyCode.A))
        {
            rightOn = false;
            leftOn = true;
            MoveLeft();
        }
        if(Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            anim.SetBool("CanWalk",false);
        }
        if(Input.GetKey(KeyCode.W))
        {
            if(ps.activePlayer == this.gameObject)
                Jump();
        }
    }

    void MoveLeft()
    {
        littlePlayer.transform.localScale = new Vector3(-0.8f, 0.8f, 0.8f);
        transform.Translate(Vector2.left*moveSpeed*Time.deltaTime);
        ChangeDirection(-0.9f);
        if(canJump)
        {
            anim.SetBool("CanWalk",true);
        }  
    }
    void MoveRight()
    {
        littlePlayer.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
        transform.Translate(Vector2.right*moveSpeed*Time.deltaTime);
        ChangeDirection(0.9f);
        if(canJump)
        {
            anim.SetBool("CanWalk",true);
        }
    }

    void Jump()
    {
        if(canJump)
        {
            AudioManager.instance.jumpFX();
            rb.AddForce(Vector2.up * jumpPower,ForceMode2D.Impulse);
            anim.SetBool("CanWalk",false);
            anim.SetBool("CanJump",true);
            canJump = false;
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
           
            anim.SetBool("CanJump",false);
            canJump = true;
        }
    }

    void ChangeDirection(float dir)
    {
        Vector3 temp = transform.localScale;
        temp.x = dir;
        transform.localScale = temp;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("bullet"))
        {
            tp8.SetActive(true);
            transform.position = tp8.transform.position;
            StartCoroutine(transportDelay());
        }
    }
    IEnumerator transportDelay()
    {
        yield return new WaitForSeconds(1f);
        tp8.SetActive(false);
    }
}

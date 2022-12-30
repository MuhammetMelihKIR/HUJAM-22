using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementYeni : MonoBehaviour
{
    Rigidbody2D rb;
    PlayerSwitch ps;
    Animator anim;
    [SerializeField] float moveSpeed = 2f;
    [SerializeField] float jumpPower = 5f;
    bool canJump = true;
    bool canMoveLeft = false;
    bool canMoveRight = false;
    public GameObject littlePlayer;
    public Projectile projectilePrefab;
    public Transform LaunchOffset;
    


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        ps = GameObject.Find("Player Switcher").GetComponent<PlayerSwitch>();
    }

    private void Update()
    {
        

        if (ps.activePlayer == this.gameObject)
        {
            PlayerInputs();
            MoveLeft();
            MoveRight();

            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Instantiate(projectilePrefab, LaunchOffset.position, transform.rotation);
                Debug.Log("atess");
            }

        }
        
    }
    void PlayerInputs()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
              
            gameObject.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
            littlePlayer.transform.localScale= new Vector3(0.8f, 0.8f, 0.8f);
            canMoveRight = true;
            canMoveLeft = false;
            anim.SetBool("CanWalk", true);
            
            
        }
        if(Input.GetKeyDown(KeyCode.A))
        {
           
            gameObject.transform.localScale = new Vector3(-0.8f, 0.8f, 0.8f);
            littlePlayer.transform.localScale = new Vector3(-0.8f, 0.8f, 0.8f);
            canMoveLeft = true;
            canMoveRight = false;
            anim.SetBool("CanWalk",true);
        }
        if(Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            anim.SetBool("CanWalk",false);
            
        }
        if(Input.GetKey(KeyCode.W))
        {
            if(ps.activePlayer == this.gameObject)
            {
                Jump();
                anim.SetBool("CanWalk", false);
               
            }
                
        }
        if(Input.GetKeyUp(KeyCode.A))
        {
            canMoveLeft = false;
        }
        if(Input.GetKeyUp(KeyCode.D))
        {
            canMoveRight = false;
        }
    }

    void MoveLeft()
    {
        if(canMoveLeft)
        {
            transform.Translate(Vector2.left*moveSpeed*Time.deltaTime);
            anim.SetBool("CanWalk",true);
            
        }
            
    }
    void MoveRight()
    {
        if(canMoveRight)
        {
            transform.Translate(Vector2.right*moveSpeed*Time.deltaTime);   
            anim.SetBool("CanWalk",true);
            
        }
            
    }

    void Jump()
    {
        if(canJump)
        {
            rb.AddForce(Vector2.up * jumpPower,ForceMode2D.Impulse);
            anim.SetBool("CanWalk",false);
            anim.SetBool("CanJump",true);
            canJump = false;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            Debug.Log("ground TRIGGERED");
            anim.SetBool("CanJump",false);
            canJump = true;
        }
    }

    
}

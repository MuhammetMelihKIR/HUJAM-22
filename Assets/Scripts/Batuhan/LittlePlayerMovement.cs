using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LittlePlayerMovement : MonoBehaviour
{
    [SerializeField] Vector3 followOffSet;
    PlayerSwitch ps;
    public GameObject bigPlayer;
    [SerializeField] float moveSpeed = 2f;
    public float horizontalInput;
    public float verticalInput;
    public static bool LittleDamage = false;
    void Start()
    {
        ps = GameObject.Find("Player Switcher").GetComponent<PlayerSwitch>();
    }
    void Update()
    {
        if(ps.activePlayer != this.gameObject)
            FollowToPlayer();
        else
            LittleMovement();

        
    }

    void LittleMovement()
    {
        

        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.localScale = new Vector3(-0.8f, 0.8f, 0.8f);
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
            ChangeDirection(-0.8f);
        }
        if(Input.GetKey(KeyCode.D))
        {
            gameObject.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
            ChangeDirection(0.8f);
        }
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);
        }
    }

    void FollowToPlayer()
    {
        transform.position = bigPlayer.transform.position + followOffSet;
    }

    void ChangeDirection(float dir)
    {
        Vector3 temp = transform.localScale;
        temp.x = dir;
        transform.localScale = temp;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacle") || collision.CompareTag("bullet"))
        {
            LittleDamage = true;
        }
    }
}

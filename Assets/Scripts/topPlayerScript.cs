using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topPlayerScript : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if(yeni.rightOn==true)
        rb.velocity = transform.right * speed;
        if (yeni.leftOn == true)
        rb.velocity = -transform.right * speed;

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("player"))
            Destroy(gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var enemy = collision.collider.GetComponent<EnemyCont>();
        if (enemy)
        {
            enemy.takeHit(1);
        }
        Destroy(gameObject);
    }
}

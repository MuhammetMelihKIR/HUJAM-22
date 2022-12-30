using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 1f;
        

    // Update is called once per frame
    void Update()
    {
        transform.position+=transform.right*speed*Time.deltaTime;
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

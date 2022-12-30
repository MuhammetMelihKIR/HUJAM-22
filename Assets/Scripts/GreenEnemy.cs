using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenEnemy : MonoBehaviour
{
    public GameObject bullet;
    public Transform firePoint;
    float timeBetween;
    public float startTimeBetween;
    bool canShoot;


    // Start is called before the first frame update
    void Start()
    {
        timeBetween = startTimeBetween;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeBetween <= 0 && canShoot)
        {
            Instantiate(bullet, firePoint.position, firePoint.rotation);
            timeBetween = startTimeBetween;
        }
        else
        {
            timeBetween -= Time.deltaTime;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("player"))
        {
            canShoot = true;
        }

        if (collision.CompareTag("playerBullet"))
        {
            gameObject.SetActive(false);
            
        }
    }
    


}

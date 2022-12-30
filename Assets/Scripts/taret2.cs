using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class taret2 : MonoBehaviour
{
    public GameObject bullet;
    public Transform firePoint;
    float timeBetween;
    public float startTimeBetween;
    
   


    // Start is called before the first frame update
    void Start()
    {
        timeBetween = startTimeBetween;
    }

    // Update is called once per frame
    void Update()
    {
        if(timeBetween <= 0)
        {
            Instantiate(bullet,firePoint.position,firePoint.rotation);
            timeBetween =startTimeBetween;
        }
        else
        {
            timeBetween -= Time.deltaTime;
        }

    }
    
   
}

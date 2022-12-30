using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batteryScript : MonoBehaviour
   
{
    public static bool take;
    // Start is called before the first frame update
    void Start()
    {
        take=false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("player"))
        {
            
            Destroy(gameObject);
            take = true;

        }
    }
}


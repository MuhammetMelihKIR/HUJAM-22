using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class motorScript : MonoBehaviour
{
    public GameObject text;
    

    // Start is called before the first frame update
    void Start()
    {
        text.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("player"))
        {
            text.SetActive(true);
            
        }
           
    }
}

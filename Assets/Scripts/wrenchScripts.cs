using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wrenchScripts : MonoBehaviour
{
    public static bool takeWrench;
    public GameObject move;
    // Start is called before the first frame update
    void Start()
    {
        takeWrench = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("little"))
        {
           
            Destroy(gameObject);
            takeWrench = true;
            Destroy(move);

        }
    }
}

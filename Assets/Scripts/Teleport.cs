using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject tp1, tp2, tp3, tp4, tp5, tp6, tp7,tp8, BigPlayer;
    public bool keyOn;
    public GameObject tebrikler;
    void Start()
    {
        keyOn=false;
        tebrikler.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            keyOn = true;
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            keyOn = false;
        }

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "teleport" && keyOn==true )
        {

            gameObject.transform.position = new Vector3(tp2.transform.position.x, tp2.transform.position.y);

        }
        if (collision.tag == "teleport1" && keyOn == true)
        {

            gameObject.transform.position = new Vector3(tp4.transform.position.x, tp4.transform.position.y);

        }
        if (collision.tag == "teleport3" && keyOn == true && wrenchScripts.takeWrench==true)
        {

            gameObject.transform.position = new Vector3(tp6.transform.position.x, tp6.transform.position.y);

        }
        if (collision.tag == "teleport4" && keyOn == true && batteryScript.take==true)
        {

            gameObject.transform.position = new Vector3(tp8.transform.position.x, tp8.transform.position.y);
            Destroy(tp8,1f);

            tebrikler.SetActive(true);

        }



    }
}

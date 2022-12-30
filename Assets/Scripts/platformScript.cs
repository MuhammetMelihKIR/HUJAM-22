using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class platformScript : MonoBehaviour
{
    public GameObject enemy1,enemy2,enemy3;
    public static bool destroy1=false;
    public static bool destroy2=false;
    public static bool destroy3=false;

   
    

    private void Start()
    {
        
    }

 

    private void Update()
    {
        if (destroy3 == true)
        {
            gameObject.SetActive(false);    
        }
    }
}



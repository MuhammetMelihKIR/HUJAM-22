using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.Burst.Intrinsics.Arm;

public class ButtonScript : MonoBehaviour
{
    public Transform firstPos, secondPos;
    public float speed;
    public bool keyOn;
    public bool button;

    Vector3 nextPos;
    void Start()
    {
        nextPos = firstPos.position;
        
    }

    // Update is called once per frame
    void Update()
    {
            

        if ( (transform.position == firstPos.position))
        {
            nextPos = secondPos.position;
            transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
        }
      

        
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(firstPos.position, secondPos.position);

    }
   
}

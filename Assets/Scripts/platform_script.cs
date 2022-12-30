
using UnityEngine;

public class platform_script : MonoBehaviour
{
    public Transform firstPos, secondPos;
    public float speed;

    Vector3 nextPos;
    void Start()
    {
        nextPos = firstPos.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == firstPos.position)
        {
            nextPos=secondPos.position;
        }
        if (transform.position == secondPos.position)
        {
            nextPos = firstPos.position;
        }

        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed*Time.deltaTime);
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(firstPos.position, secondPos.position);

    }

  


}

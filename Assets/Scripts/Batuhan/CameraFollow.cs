using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    PlayerSwitch ps;
    public float FollowSpeed;
    GameObject activePlayer;
    public static float yOffset = 10;
    // Start is called before the first frame update
    void Start()
    {
        ps = GameObject.Find("Player Switcher").GetComponent<PlayerSwitch>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        activePlayer = ps.activePlayer;
        Vector3 newPos = new Vector3(activePlayer.transform.position.x, activePlayer.transform.position.y + yOffset, -10f);
        transform.position = Vector3.Lerp(transform.position, newPos, FollowSpeed * Time.deltaTime);
    }
}

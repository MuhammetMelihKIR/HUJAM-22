using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwitch : MonoBehaviour
{
    public GameObject Player;
    public GameObject littlePlayer;

    public GameObject activePlayer;
    // Start is called before the first frame update
    void Start()
    {
        activePlayer = Player;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            AudioManager.instance.characterSwitchFX();
            if (activePlayer == Player)
            {
                
                activePlayer = littlePlayer;
                CameraFollow.yOffset = 5;
            }


            else
            {
                
                activePlayer = Player;
                CameraFollow.yOffset = 10;
            }
                
        }

       if( LittlePlayerMovement.LittleDamage == true)

        {
            activePlayer=Player;
            CameraFollow.yOffset = 10;
            LittlePlayerMovement.LittleDamage = false;  

        }
        
    }
}

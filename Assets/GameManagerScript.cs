using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    public Button devam, sesAc, sesKapa;
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Time.timeScale = 0f;
            panel.SetActive(true);
        }
            
    }

    public void continueGame()
    {
        panel.SetActive(false);
        Time.timeScale = 1.0f;
    }

    public void sesAcButton()
    {
        AudioManager.instance.stopSound();   
    }

    public void SesAc()
    {
        AudioManager.instance.StartSound();
    }
}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
     AudioSource audioSource;
    public static AudioManager instance;
    public AudioClip shoot;
    public AudioClip destroyEnemy;
    public AudioClip jump;
    public AudioClip characterSwitch;
    // Start is called before the first frame update
    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        if(instance == null)
        {
            instance=this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void shootFX()
    {
       audioSource.PlayOneShot(shoot);
    }

    public void jumpFX()
    {
        audioSource.PlayOneShot(jump);
    }

    public void destroyEnemyFX()
    {
        audioSource.PlayOneShot(destroyEnemy);
    }

    public void characterSwitchFX()
    {
        audioSource.PlayOneShot(destroyEnemy);
    }

    public void stopSound()
    {
        audioSource.Stop();
    }

    public void StartSound()
    {
        audioSource.Play();
    }
}

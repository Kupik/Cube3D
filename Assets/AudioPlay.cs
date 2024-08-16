using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlay : MonoBehaviour
{
    private static GameObject soundManager;

    public AudioSource StartGamesMusic;

    

    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        
    }


   

    public void AudioPlayGame ()
    {
       if(!StartGamesMusic.isPlaying)
        {

        
            StartGamesMusic.Play();
        }
    }

}

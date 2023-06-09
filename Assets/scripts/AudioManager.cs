using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AudioManager : MonoBehaviour
{
    private AudioSource audioPlayer;
    public AudioClip mainLoop;
    public AudioClip tavernLoop;
    public AudioClip battleLoop;
    public AudioClip blacksmithLoop;
    public AudioClip wizardLoop;
    public int musicState = 1;
    [HideInInspector]
    public bool canPlay = true;
    // Start is called before the first frame update
    void Start()
    {
        audioPlayer = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        if (canPlay == true)
        {
            canPlay = false;
            if (musicState == 1)
            {
                audioPlayer.clip = mainLoop;
                audioPlayer.volume = 0.4f;
                audioPlayer.Play();
            }
            if (musicState == 2)
            {
                audioPlayer.clip = tavernLoop;
                audioPlayer.volume = 0.4f;
                audioPlayer.Play();
            }
            if (musicState == 3)
            {
                audioPlayer.clip = battleLoop;
                audioPlayer.volume = 0.3f;
                audioPlayer.Play();
            }
            if (musicState == 4)
            {
                audioPlayer.clip = blacksmithLoop;
                audioPlayer.volume = 0.4f;
                audioPlayer.Play();
            }
            if (musicState == 5)
            {
                audioPlayer.clip = wizardLoop;
                audioPlayer.volume = 0.4f;
                audioPlayer.Play();
            }
        }
    }
}
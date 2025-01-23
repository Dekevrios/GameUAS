using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager soundManage;
    private AudioSource audioSrc;
    private AudioClip[] coinSounds;
    private int randomCoinSound;
    // Start is called before the first frame update
    void Start()
    {
        soundManage = this;
        audioSrc = GetComponent<AudioSource>();
        coinSounds = Resources.LoadAll<AudioClip>("CoinSound");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayCoinSound()
    {
        
    }
}

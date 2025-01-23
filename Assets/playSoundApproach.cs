using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playSoundApproach : MonoBehaviour
{
    public AudioSource audioSource;
    public Transform player; //cek posisi player
    public float triggerDistance = 5f;

    // Start is called before the first frame update
    void Start()
    {
        if(audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(player.position, transform.position);

        //player dlm range
        if(distance <= triggerDistance )
        {
            if(!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
        else
        {
            if(audioSource.isPlaying)
            {
                audioSource.Stop();
            }
        }
    }

    //private void OnTriggerEnter2D(Collider2D obj)
    //{
    //    if (obj.CompareTag("Player"))
    //    {
    //        //play sound
    //        if(!audioSource.isPlaying)
    //        {
    //            audioSource.Play();
    //        }
    //    }
    //}

    //private void OnTriggerExit2D(Collider2D obj)
    //{
    //    if (obj.CompareTag("Player"))
    //    {
    //        audioSource.Stop();
    //    }
    //}
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class goldStats : MonoBehaviour
{
    public int plusGd = 1;
    private AudioSource audioSource;
    private PolygonCollider2D itemCollider;
    private SpriteRenderer sr;

    
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        itemCollider = GetComponent<PolygonCollider2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.gameObject.CompareTag("Player"))
        {
            charStats stats = obj.GetComponent<charStats>();
            stats.setHp(plusGd);
            Debug.Log("Diambil");
            gameManager.instance.hpDisplay(stats.currHp.ToString());

            audioSource.Play();
            itemCollider.enabled = false;
            sr.enabled = false;

            //Destroy(gameObject, audioSource.clip);

        }
    }
}

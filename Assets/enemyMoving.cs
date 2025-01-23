using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class enemyMoving : MonoBehaviour
{
   

    public float moveSpeed = 2f;
    Rigidbody2D rb;
    Transform target;
    Vector2 vector;
    Animator animator;
    SpriteRenderer sr;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }


    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (target)
        {
            Vector3 direction = (target.position - transform.position).normalized;
            vector = direction;

            //float angle = Mathf.Atan2(direction.y , direction.x);
        }
    }

    private void FixedUpdate()
    {
        animator.SetFloat("Horizontal", vector.x);
        animator.SetFloat("Vertical", vector.y);
        animator.SetFloat("Speed", vector.sqrMagnitude);

        if (target)
        {
            rb.velocity = new Vector2(vector.x, vector.y) * moveSpeed;
        }
        if(vector.x != 0)
        {
            sr.flipX = vector.x < 0 ;
        }
            
    }
 
}

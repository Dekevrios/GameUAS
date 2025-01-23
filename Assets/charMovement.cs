using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class charMovement : MonoBehaviour
{
    Rigidbody2D rb;
    Animator animator;
    SpriteRenderer sr;
    public float movSpeed = 5f;

    //public bool isAttack = false;

    public Transform attackPoint;
    public float attRange;
    public LayerMask enemyLayers;


    Vector2 vector2;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Attack();
        }
    }

    private void FixedUpdate()
    {
        vector2.x = Input.GetAxisRaw("Horizontal");
        vector2.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", vector2.x);
        animator.SetFloat("Vertical", vector2.y);
        animator.SetFloat("Speed", vector2.sqrMagnitude);

        rb.MovePosition(rb.position + vector2 * movSpeed * Time.fixedDeltaTime);
        if (vector2.x != 0)
        {
            sr.flipX = vector2.x < 0;
        }

        //if (Input.GetButtonDown("Fire1"))
        //{
        //    animator.SetTrigger("Attack");
        //}
       

    }

    void Attack()
    {
        animator.SetTrigger("Attack");

        //Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attRange, enemyLayers);


        //foreach (Collider2D enemy in hitEnemies)
        //{
        //    enemy.GetComponent<enemyStats>().TakeDamage();
        //}
    }
}

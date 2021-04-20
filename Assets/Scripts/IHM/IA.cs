using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework.Constraints;
using UnityEngine;

public class IA : MonoBehaviour
{
    public Rigidbody2D rb;
    private Vector2 dir;
    
    public float speed = 5f;
    private float horizontalMovement;
    private float verticalMovement;

    private bool verifMove;
    private bool isMoving;
    
    private Transform target;
    public SpriteRenderer graphics;
    public Transform waypoint;
    
    void Start()
    {
        target = waypoint;
        graphics = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        moveIA();
    }

    public void getMove()
    {
        verifMove = true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Test");
    }

    void moveIA()
    {
        if (target.position.x > transform.position.x)
        {
            dir.x = 1;
        }
        if (target.position.x <= transform.position.x)
        {
            dir.x = -1;
        }

        if (Mathf.Abs(target.position.x - transform.position.x) < 0.05f)
        {
            dir.x = 0;
        }
        
        if (target.position.y > transform.position.y)
        {
            dir.y = 1;
        }
        if (target.position.y <= transform.position.y)
        {
            dir.y = -1;
        }
        if (Mathf.Abs(target.position.y - transform.position.y) < 0.05f)
        {
            dir.y = 0;
        }

        if (verifMove)
        {
            rb.MovePosition(rb.position + dir * speed * Time.fixedDeltaTime);
        }
    }
}

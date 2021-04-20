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
    
    void moveIA()
    {
        if (verifMove)
        {
            
        }
    }
}

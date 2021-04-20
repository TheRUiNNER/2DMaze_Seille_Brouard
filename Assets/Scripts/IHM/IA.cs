using System.Collections;
using System.Collections.Generic;
using NUnit.Framework.Constraints;
using UnityEngine;

public class IA : MonoBehaviour
{
    public float speed;
    private float horizontalMovement;
    private float verticalMovement;

    private bool verifMove;
    
    private Transform target;
    public SpriteRenderer graphics;
    public Transform waypoint;
    
    public Rigidbody2D rb;
    private Vector3 velocity = Vector3.zero;


    void Start()
    {
        target = waypoint;
        graphics = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if (target.position.x > transform.position.x)
        {
            horizontalMovement = 0.5f;
        }
        if (target.position.x < transform.position.x)
        {
            horizontalMovement = -0.5f;
        }

        if (target.position.x == transform.position.x)
        {
            horizontalMovement = 0f;
        }

        if (target.position.y > transform.position.y)
        {
            verticalMovement = 0.5f;
        }
        if (target.position.y < transform.position.y)
        {
            verticalMovement = -0.5f;
        }

        if (target.position.y == transform.position.y)
        {
            verticalMovement = 0;
        }

        MoveIA(horizontalMovement,verticalMovement);
    }

    void MoveIA(float _horizontalMovement, float _verticalMovement)
    {
        if(verifMove)
        {
            transform.position = new Vector2(transform.position.x + _horizontalMovement,transform.position.y + _verticalMovement);
        }
    }

    public void getMove()
    {
        verifMove = true;
    }
}

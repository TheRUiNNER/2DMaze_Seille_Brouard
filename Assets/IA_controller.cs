using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Pathfinding;
using UnityEngine;
using UnityEngine.AI;
using Debug = UnityEngine.Debug;

public class IA_controller : MonoBehaviour
{
    private AIPath IA;
    
    public GameObject errorMenuUI;

    public Transform closedDoor;

    public Transform targetPosition;

    public Animator _animator;
    
    private bool doorCollision;
    
    public void Update()
    {
        Vector3 dir = closedDoor.transform.position - transform.position;
        dir = closedDoor.transform.InverseTransformDirection(dir);
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;

        if (angle >= 45 && angle < 135)
        {
            _animator.SetInteger("position",2);
        }
        else if((angle <= 180 && angle >= 135) || (angle >= -180 && angle <=-135))
        {
            _animator.SetInteger("position",1);
        }

        else if((angle <= 45 && angle >=0) || (angle <= 0 && angle >=-45))
        {
            _animator.SetInteger("position",3);
        }
        else
        {
            _animator.SetInteger("position",0);
        }

        if (!doorCollision)
        {
            verificationChemin();
        }
    }
    public void addVelocity()
    {
        IA = GetComponent<AIPath>();
        
        IA.maxSpeed = 3;
    }

    public void removeVelocity()
    {
        IA = GetComponent<AIPath>();
        
        IA.maxSpeed = 0;
    }

    public void verificationChemin()
    {
        bool path = IA.reachedEndOfPath;

        if (path)
        {
            errorMenuUI.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            errorMenuUI.SetActive(false);
            Time.timeScale = 1f;
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        
        if (collision.CompareTag("Victory"))
        {
            doorCollision = true;
        }
        else
        {
            doorCollision = false;
        }
    }
}

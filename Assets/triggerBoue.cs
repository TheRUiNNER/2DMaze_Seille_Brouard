using System;
using System.Collections;
using System.Collections.Generic;
using Pathfinding;
using UnityEngine;

public class triggerBoue : MonoBehaviour
{
    private AIPath _aiPath;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _aiPath = GetComponent<AIPath>();
        
        if (collision.CompareTag("Boue"))
        {
            _aiPath.maxSpeed = 0.5f;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _aiPath = GetComponent<AIPath>();
        _aiPath.maxSpeed = 3;
    }
}

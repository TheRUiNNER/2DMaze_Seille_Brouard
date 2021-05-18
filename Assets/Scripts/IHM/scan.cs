using System;
using System.Collections;
using System.Collections.Generic;
using Pathfinding;
using UnityEngine;

public class scan : MonoBehaviour
{
    public AIPath IA;

    private void Awake()
    {
        IA = GetComponent<AIPath>();
    }

    public void scanner()
    {
        AstarPath.active.Scan();
    }
}

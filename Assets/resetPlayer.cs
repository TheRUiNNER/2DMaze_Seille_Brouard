using System.Collections;
using System.Collections.Generic;
using Pathfinding;
using UnityEngine;

public class resetPlayer : MonoBehaviour
{
    public Transform IA;
    public void resetPosition()
    {
        IA.position = transform.position;
    }
}

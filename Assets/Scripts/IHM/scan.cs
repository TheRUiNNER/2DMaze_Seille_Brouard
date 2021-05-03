using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scan : MonoBehaviour
{
    public void scanner()
    {
        AstarPath.active.Scan();
    }
}

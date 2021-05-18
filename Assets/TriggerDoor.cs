using System.Collections;
using System.Collections.Generic;
using Pathfinding;
using UnityEngine;

public class TriggerDoor : MonoBehaviour
{

    public GameObject Endscreen;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Victory"))
        {
            Endscreen.gameObject.SetActive(true);
            
            Time.timeScale = 0f;
        }
    }
}

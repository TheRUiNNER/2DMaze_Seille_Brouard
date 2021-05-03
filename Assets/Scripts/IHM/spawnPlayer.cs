using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPlayer : MonoBehaviour
{
    public Transform player;
    private bool spawned = false;

    public void SpawnPlayer()
    {
        if (!spawned)
        {
            player.position = transform.position;

            spawned = true;
        }
    }
}

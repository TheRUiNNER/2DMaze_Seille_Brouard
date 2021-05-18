using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPlayer : MonoBehaviour
{
    public Transform player;

    public void SpawnPlayer()
    {
        player.position = transform.position;
    }
}

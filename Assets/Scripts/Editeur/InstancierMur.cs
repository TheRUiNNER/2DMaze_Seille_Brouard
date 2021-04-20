using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstancierMur : MonoBehaviour
{
    public GameObject WallPrefab;

    // Update is called once per frame
    void Update()
    {
        Instantiate(WallPrefab);
    }
}

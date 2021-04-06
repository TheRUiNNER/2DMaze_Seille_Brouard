using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA : MonoBehaviour
{
    public float speed;
    private Transform target;
    public SpriteRenderer graphics;
    public Transform[] waypoints;
    
    
    void Start()
    {
        target = waypoints[0];
        graphics = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
    }
}

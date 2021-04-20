using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    public GameObject WallPrefab;

    private bool isDragging = false;
    
    public void OnMouseDown()
    {
        isDragging = true;
        Instantiate(WallPrefab);
    }

    public void OnMouseUp()
    {
        isDragging = false;
    }

    private void Update()
    {

        if (isDragging)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 deplacerParCase = new Vector2((int) mousePosition.x + 0.5f, (int) mousePosition.y + 0.5f);

            transform.position = deplacerParCase;
        }
    }
    public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Destroy(WallPrefab);
        }
    }
}

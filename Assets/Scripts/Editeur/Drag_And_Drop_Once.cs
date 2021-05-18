using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag_And_Drop_Once : MonoBehaviour
{

    private bool isDragging = false;

    private int deplacement;

    public void OnMouseDown()
    {
        isDragging = true;
    }

    public void OnMouseUp()
    {
        isDragging = false;
    }

    private void Update()
    {
        deplacement = PlayerPrefs.GetInt("deplacerObjet");
        
        if (isDragging && deplacement==1)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 deplacerParCase = new Vector2((int) mousePosition.x + 0.5f, (int) mousePosition.y + 0.5f);

            transform.position = deplacerParCase;
        }
    }
}

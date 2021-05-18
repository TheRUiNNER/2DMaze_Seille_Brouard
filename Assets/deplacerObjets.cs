using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deplacerObjets : MonoBehaviour
{
    private int deplacement = 1;
    void Update()
    {
        PlayerPrefs.SetInt("deplacerObjet",deplacement);
    }

    public void setDeplacement()
    {
        if (deplacement == 0)
        {
            deplacement = 1;
        }
        else
        {
            deplacement = 0;
        }
    }
    
}

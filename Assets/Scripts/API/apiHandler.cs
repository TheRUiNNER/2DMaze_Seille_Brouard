using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class apiHandler : MonoBehaviour
{
    private string baseURL = "http://127.0.0.1:8080/api/mazeModel";

    string leveltitle ="";
    string creatorname ="";
    string json ="ma couille !";

    public InputField levelTitle;
    public InputField creatorName;
    
    public void Executed()
    {
        leveltitle = levelTitle.text;
        creatorname = creatorName.text;
        
        StartCoroutine(saveMapOnDB(leveltitle, creatorname, json));
    }
    

    /*private IEnumerator getLastOccurenceOfId()
    {
        using (UnityWebRequest mapInfoRequest = UnityWebRequest.Get(baseURL))
        {
            if (mapInfoRequest.result == UnityWebRequest.Result.ConnectionError)
            {
                Debug.LogError(mapInfoRequest.error);
            }
            else
            {
                string rawdata = mapInfoRequest.downloadHandler.text;
            }
        }
    }*/

    IEnumerator saveMapOnDB(string leveltitle, string creatorName, string jsonString)
    {
        WWWForm formdata = new WWWForm();
        formdata.AddField("titre",leveltitle);
        formdata.AddField("auteur",creatorName);
        formdata.AddField("contenu",jsonString);

        Debug.Log(leveltitle);
        Debug.Log(creatorName);
        Debug.Log(jsonString);

        UnityWebRequest www = UnityWebRequest.Post(baseURL,formdata);
        yield return www.SendWebRequest();

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log(www.error);
        }
        else
        {
            //
            Debug.Log("success");
        }
    }
}


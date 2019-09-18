using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quitScript : MonoBehaviour
{
    public void doquit()
    {
        Debug.Log("Quit");
        //UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}

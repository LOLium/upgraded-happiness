using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUI : MonoBehaviour
{

    [SerializeField]
    GameObject pauseMenu;

    // Start is called before the first frame update
    void Start()
    {
        MyPauseMenu.IsOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }

    void TogglePause()
    {
        pauseMenu.SetActive(!pauseMenu.activeSelf);
        MyPauseMenu.IsOn = pauseMenu.activeSelf;
    }
}

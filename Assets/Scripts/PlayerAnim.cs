using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerAnim : NetworkBehaviour
{
    public Animator playerAnimation;

    // Update is called once per frame
    void Update()
    {
        checkForPlayerInput();
    }

    void checkForPlayerInput()
    {
        if(!isLocalPlayer)
        {
            return;
        }

        if(Mathf.Abs(Input.GetAxis("Vertical"))>0||
            Mathf.Abs(Input.GetAxis("Horizontal"))>0)
        {
            playerAnimation.SetBool("moving", true);
        }
        else
        {
            playerAnimation.SetBool("moving", false);
        }
    }
}

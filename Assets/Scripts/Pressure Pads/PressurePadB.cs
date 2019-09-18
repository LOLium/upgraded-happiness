using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePadB : MonoBehaviour
{

    [SerializeField]
    GameObject doorA;

    [SerializeField]
    GameObject doorB;

    bool isOpened = false;

    private void OnTriggerEnter(Collider other)
    {

        if (!isOpened)
        {
            doorA.transform.position += new Vector3(0, 3.32f, 0);
            doorB.transform.position += new Vector3(0, 3.32f, 0);
            isOpened = true;
        }
    }
}

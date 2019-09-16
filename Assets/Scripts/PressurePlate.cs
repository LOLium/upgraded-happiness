using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    Animator animator;
    bool isOpen = false;

    public AudioClip audioclip;
    public float volume;
    AudioSource audioSource;
    

    [SerializeField]
    GameObject door;

    private void Start()
    {
        isOpen = false;
        animator = door.GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider abc)
    {
        if (abc.gameObject.tag == "Player" && !isOpen)
        {
            isOpen = true;
            door_animation("Open");
            audioSource.PlayOneShot(audioclip, volume);
        }
    }

    private void OnTriggerExit(Collider abc)
    {
        if(isOpen)
        {
            isOpen = false;
            door_animation("Close");
            audioSource.PlayOneShot(audioclip, volume);
        }
    }

    void door_animation(string direction)
    {
        animator.SetTrigger(direction);
    }
}

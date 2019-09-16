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

    private IEnumerator OnTriggerEnter(Collider abc)
    {
        if (abc.gameObject.tag == "Player" && !isOpen)
        {
            door_animation("Open");
            audioSource.PlayOneShot(audioclip, volume);
            yield return new WaitForSeconds(5);
            isOpen = true;
            //if(true)
            //{
            //    door_animation("Close");
            //    audioSource.PlayOneShot(audioclip, volume);
            //    yield return new WaitForSeconds(5);
            //    isOpen = false;
            //}
        }
    }

    private IEnumerator OnTriggerExit(Collider abc)
    {
        if(isOpen)
        {
            door_animation("Close");
            audioSource.PlayOneShot(audioclip, volume);
            yield return new WaitForSeconds(5);
            isOpen = false;
        }
    }

    void door_animation(string direction)
    {
        animator.SetTrigger(direction);
    }
}

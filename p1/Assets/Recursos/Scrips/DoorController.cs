using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public Animator leftAnim;
    public Animator rightAnim;

    private bool isOpen = false;

    [Header("Audio")]
    public AudioSource audioSource;
    public AudioClip openSound;
    public AudioClip closeSound;

    public void ToggleDoor()
    {
        if (!GameManager.instancia.tieneLlave)
        {
            Debug.Log("Necesitas la llave");
            return;
        }

        isOpen = !isOpen;

        Debug.Log("TOGGLE FUNCIONA: " + isOpen);

        leftAnim.SetBool("isOpen", isOpen);
        rightAnim.SetBool("isOpen", isOpen);

        if (isOpen)
        {
            audioSource.PlayOneShot(openSound);
        }
        else
        {
            audioSource.PlayOneShot(closeSound);
        }
    }
}
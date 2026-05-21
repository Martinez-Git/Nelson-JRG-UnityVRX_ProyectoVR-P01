  using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public Animator leftAnim;   // Animator de la hoja izquierda
    public Animator rightAnim;  // Animator de la hoja derecha

    private bool isOpen = false; // Estado de la puerta

    [Header("Audio")]
    public AudioSource audioSource;
    public AudioClip openSound;
    public AudioClip closeSound;



    public void ToggleDoor()
    {
        isOpen = !isOpen;

        Debug.Log("TOGGLE FUNCIONA: " + isOpen);

        leftAnim.SetBool("isOpen", isOpen);
        rightAnim.SetBool("isOpen", isOpen);

        // 🔊 Sonido
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

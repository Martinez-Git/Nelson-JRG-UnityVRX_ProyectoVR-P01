using UnityEngine;

public class LlaveRecolectable : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Llave recogida");

            GameManager.instancia.tieneLlave = true;

            gameObject.SetActive(false);
        }
    }
}
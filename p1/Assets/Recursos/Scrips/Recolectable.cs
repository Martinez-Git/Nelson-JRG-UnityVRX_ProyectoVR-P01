using UnityEngine;

public class Recolectable : MonoBehaviour
{
    public static int contador = 0;
    public AudioClip sonidoRecoger;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            contador++;

            //Contador
            Debug.Log("Objetos: " + contador);

            GameManager.instancia.SumarObjeto();

            //Sonido
            AudioSource.PlayClipAtPoint(
               sonidoRecoger,
               transform.position
           );

            //Destruir 
            Destroy(gameObject);
        }
    }
}
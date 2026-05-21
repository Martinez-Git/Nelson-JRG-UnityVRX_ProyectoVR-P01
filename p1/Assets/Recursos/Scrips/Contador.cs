using UnityEngine;
using TMPro;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public static GameManager instancia;

    public TextMeshProUGUI textoContador;
    public TextMeshProUGUI textoCuenta;

    public Transform jugador;
    public GameObject llave;

    int contador = 0;
    bool eventoActivado = false;

    private void Awake()
    {
        instancia = this;
    }

    public void SumarObjeto()
    {
        contador++;

        if (textoContador != null)
            textoContador.text = "" + contador + "/3";

        if (contador >= 3 && !eventoActivado)
        {
            eventoActivado = true;
            StartCoroutine(CuentaRegresiva());
        }
    }

    IEnumerator CuentaRegresiva()
    {
        textoCuenta.text = "3";
        yield return new WaitForSeconds(1);

        textoCuenta.text = "2";
        yield return new WaitForSeconds(1);

        textoCuenta.text = "1";
        yield return new WaitForSeconds(1);

        textoCuenta.text = "¡LLAVE OBTENIDA!";

        Vector3 posicionFrente = jugador.position + jugador.forward * 2f;
        posicionFrente.y += 1.5f;

        llave.transform.position = posicionFrente;
        llave.SetActive(true);

        Destroy(textoCuenta, 3f);
    }
}



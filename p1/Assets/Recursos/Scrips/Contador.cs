using UnityEngine;
using TMPro;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public static GameManager instancia;

    public TextMeshProUGUI textoContador;
    public TextMeshProUGUI textoCuenta;
    public bool tieneLlave = false;

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

        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
        Vector3 posicionFrente = ray.origin + ray.direction * 10f;

        llave.transform.position = posicionFrente;
        llave.SetActive(true);

        Destroy(textoCuenta, 3f);
    }
}



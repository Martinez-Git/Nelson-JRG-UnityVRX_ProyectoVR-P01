using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TurnSwitchController : MonoBehaviour
{

    public ActionBasedSnapTurnProvider SnapTurnProvider;
    public ActionBasedContinuousTurnProvider ContinuousTurnProvider;

    public bool SnapTurnActive = true;
    //Se debe correr el nuevo metodo desde el inicio de la carga de scrip actual.

    public void Awake()
    {
        //Corremos el metodo
        SwitchTurn(); // Asi se ejecuta un metodo (Predefinido por el usuario).
    }

    //ahora necesitamos ejecutar el nuevo metodo desde el editor de unity.

    [ContextMenu("Ejecutar -> SwitchTurn")] //Esto permite ejecutar el metodo en la siguiente linea
    public void SwitchTurn()
    {
        if (SnapTurnActive == true) //Si SNAP verdadero -> activar continuous.
        {
            SnapTurnActive = false;
            ContinuousTurnProvider.turnSpeed = 60;
        }
        else if (SnapTurnActive == false) // Si SNAP falso -> desactivar continuosus.
        {
            SnapTurnActive = true;
            ContinuousTurnProvider.turnSpeed = 0;
        }
    }

}

using System;
using UnityEngine;

public class NotificadorJugador : MonoBehaviour
{
    public static event Action alChocarConObjetivo;

    private void OnTriggerEnter2D(Collider2D otroObjeto)
    {
        if (otroObjeto.CompareTag("ObjetivoDisparo"))
        {
            alChocarConObjetivo?.Invoke();
        }
    }
}

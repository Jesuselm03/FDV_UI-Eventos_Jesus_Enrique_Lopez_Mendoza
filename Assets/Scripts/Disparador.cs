using UnityEngine;

public class Disparador : MonoBehaviour
{
    public GameObject prefabProyectil;
    public Transform puntoDeDisparo;

    public void Disparar()
    {
        if (prefabProyectil != null && puntoDeDisparo != null)
        {
            GameObject nuevoProyectil = Instantiate(prefabProyectil, puntoDeDisparo.position, prefabProyectil.transform.rotation);

            Destroy(nuevoProyectil, 0.9f);
        }
    }
}
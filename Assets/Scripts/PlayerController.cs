using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidadNormal = 5f;
    public float velocidadTurbo = 10f;
    private float velocidadActual;

    void Start()
    {
        velocidadActual = velocidadNormal;
    }

    void Update()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(movimientoHorizontal, 0, 0) * velocidadActual * Time.deltaTime);
    }

    public void ActivarModoTurbo(bool estaActivado)
    {
        if (estaActivado)
        {
            velocidadActual = velocidadTurbo;
        }
        else
        {
            velocidadActual = velocidadNormal;
        }
    }
}
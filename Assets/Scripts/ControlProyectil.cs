using System.Collections;
using UnityEngine;

public class ControlProyectil : MonoBehaviour
{
    private SpriteRenderer miSpriteRenderer;
    private Animator miAnimator;

    public float tiempoParaOcultar = 1.0f;

    void Start()
    {
        miSpriteRenderer = GetComponent<SpriteRenderer>();
        miAnimator = GetComponent<Animator>();

        miSpriteRenderer.enabled = false;
    }

    public void DispararProyectil()
    {
        miSpriteRenderer.enabled = true;
        miAnimator.SetTrigger("Disparar");

        StartCoroutine(OcultarDespuesDeUnTiempo());
    }

    IEnumerator OcultarDespuesDeUnTiempo()
    {
        yield return new WaitForSeconds(tiempoParaOcultar);

        miSpriteRenderer.enabled = false;
    }
}
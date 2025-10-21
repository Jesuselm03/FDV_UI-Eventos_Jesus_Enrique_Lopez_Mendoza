using UnityEngine;

public class ControlPrefabTrigger : MonoBehaviour
{
    private SpriteRenderer miSpriteRenderer;
    private Animator miAnimator;

    void OnEnable()
    {
        NotificadorJugador.alChocarConObjetivo += Activar;
    }

    void OnDisable()
    {
        NotificadorJugador.alChocarConObjetivo -= Activar;
    }

    void Start()
    {
        miSpriteRenderer = GetComponent<SpriteRenderer>();
        miAnimator = GetComponent<Animator>();

        miSpriteRenderer.enabled = false;
    }

    void Activar()
    {
        miSpriteRenderer.enabled = true;

        miAnimator.SetTrigger("Disparar");

        Destroy(gameObject, 0.9f);
    }
}
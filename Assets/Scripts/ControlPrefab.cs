using UnityEngine;

public class ControlPrefab : MonoBehaviour
{
    void Start()
    {
        GetComponent<SpriteRenderer>().enabled = true;

        GetComponent<Animator>().SetTrigger("Disparar");
    }
}

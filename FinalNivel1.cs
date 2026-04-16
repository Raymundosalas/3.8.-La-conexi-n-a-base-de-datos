
using UnityEngine;

public class FinalNivel1 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instancia.CompletarNivel1();
            Debug.Log("Nivel 1 completado");
        }
    }
}

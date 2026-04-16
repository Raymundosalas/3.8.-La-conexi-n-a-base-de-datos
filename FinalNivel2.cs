using UnityEngine;

public class FinalNivel2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instancia.CompletarNivel2();
            Debug.Log("Nivel 2 completado");
        }
    }
}

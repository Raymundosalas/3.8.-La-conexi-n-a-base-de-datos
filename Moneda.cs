// Moneda.cs
using UnityEngine;

public class Moneda : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instancia.AgregarMoneda();
            Destroy(gameObject);
        }
    }
}

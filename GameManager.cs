
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instancia;

    public int monedas = 0;
    public bool nivel1Completado = false;
    public bool nivel2Completado = false;

    private void Awake()
    {
        if (instancia == null)
        {
            instancia = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AgregarMoneda()
    {
        monedas++;
        Debug.Log("Monedas: " + monedas);
    }

    public void CompletarNivel1()
    {
        nivel1Completado = true;

        FirebaseManager.instancia.GuardarDatos(
            monedas,
            nivel1Completado,
            nivel2Completado
        );
    }

    public void CompletarNivel2()
    {
        nivel2Completado = true;

        FirebaseManager.instancia.GuardarDatos(
            monedas,
            nivel1Completado,
            nivel2Completado
        );
    }
}

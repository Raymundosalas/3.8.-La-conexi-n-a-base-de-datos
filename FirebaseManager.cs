
using UnityEngine;
using Firebase;
using Firebase.Extensions;
using Firebase.Firestore;
using System.Collections.Generic;

public class FirebaseManager : MonoBehaviour
{
    public static FirebaseManager instancia;

    FirebaseFirestore db;

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

    void Start()
    {
        FirebaseApp.CheckAndFixDependenciesAsync().ContinueWithOnMainThread(task =>
        {
            FirebaseApp app = FirebaseApp.DefaultInstance;
            db = FirebaseFirestore.DefaultInstance;

            Debug.Log("Firebase conectado");
        });
    }

    public void GuardarDatos(int monedas, bool nivel1, bool nivel2)
    {
        DocumentReference docRef = db.Collection("jugadores").Document("jugador1");

        Dictionary<string, object> datos = new Dictionary<string, object>()
        {
            { "monedas", monedas },
            { "nivel1Completado", nivel1 },
            { "nivel2Completado", nivel2 }
        };

        docRef.SetAsync(datos).ContinueWithOnMainThread(task =>
        {
            Debug.Log("Datos guardados correctamente");
        });
    }

    public void CargarDatos()
    {
        DocumentReference docRef = db.Collection("jugadores").Document("jugador1");

        docRef.GetSnapshotAsync().ContinueWithOnMainThread(task =>
        {
            if (task.Result.Exists)
            {
                DocumentSnapshot snapshot = task.Result;

                int monedas = snapshot.GetValue<int>("monedas");
                bool nivel1 = snapshot.GetValue<bool>("nivel1Completado");
                bool nivel2 = snapshot.GetValue<bool>("nivel2Completado");

                GameManager.instancia.monedas = monedas;
                GameManager.instancia.nivel1Completado = nivel1;
                GameManager.instancia.nivel2Completado = nivel2;

                Debug.Log("Datos cargados");
            }
        });
    }
}

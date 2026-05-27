using UnityEngine;
using TMPro;

public class PickUpManager : MonoBehaviour
{
    int contador = 0;
    public TextMeshProUGUI textoContador;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coleccionable"))
        {
            contador++;
            textoContador.text = "Lápices: " + contador;
            Debug.Log("Lápices recolectados: " + contador);
            Destroy(other.gameObject);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Almacena el prefab del proyectil
    public GameObject projectilePrefab;

    // Variable de tipo Quaternion
    private Quaternion rotation;

    // Se ejecuta a cada frame
    void Update()
    {
        // Si pulsas la tecla flecha arriba
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            // Guarda el valor dado por la funci�n .Euler()
            rotation = Quaternion.Euler(Vector3.left);

            // Llama a la funci�n con "rotation" como input
            SpawnProjectile(rotation);
        }

        // Si pulsas la tecla flecha abajo
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            // Guarda el valor dado por la funci�n .Euler()
            rotation = Quaternion.Euler(Vector3.right);

            // Llama a la funci�n con "rotation" como input
            SpawnProjectile(rotation);
        }

        // Si pulsas la tecla flecha izquierda
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            // Guarda el valor dado por la funci�n .Euler()
            rotation = Quaternion.Euler(Vector3.down);

            // Llama a la funci�n con "rotation" como input
            SpawnProjectile(rotation);
        }

        // Si pulsas la tecla flecha derecha
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            // Guarda el valor dado por la funci�n .Euler()
            rotation = Quaternion.Euler(Vector3.up);

            // Llama a la funci�n con "rotation" como input
            SpawnProjectile(rotation);
        }
    }

    // Funci�n que instancia un gameObject en una posici�n y rotaci�n determinada
    // con un input de tipo Quaternion como par�metro
    public void SpawnProjectile(Quaternion rotation)
    {
        Instantiate(projectilePrefab, transform.position, rotation);
    }
}
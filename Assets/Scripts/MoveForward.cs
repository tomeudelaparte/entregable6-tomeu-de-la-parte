using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    // Almacena la velocidad del proyectil
    private float speed = 5f;

    // Almacena el valor límite en X y Y
    private float xRange = 9;
    private float yRange = 6;

    // Se ejecuta a cada frame
    void Update()
    {
        // Desplaza el proyectil hacia delante
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Comprueba si el proyectil está fuera de los límites marcados (X, Y)
        if (transform.position.x > xRange
            || transform.position.x < -xRange
            || transform.position.y > yRange
            || transform.position.y < -yRange)
        {
            // Destruye el proyectil
            Destroy(gameObject);
        }
    }
}
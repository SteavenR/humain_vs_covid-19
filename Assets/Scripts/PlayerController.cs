using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Variables pour le déplacements du joueur
    public float speed = 10;
    public float turnSpeed;
    public float horizontalInput;
    public float forwardInput;

    // Variable pour les projectiles
    public GameObject projectilePrefab;

    // Variables de la limite de la zone
    private float xLimit = 14;
    private float zLimit = 23;

    public AudioClip shootSound;


    // Le code a exécuter une seule fois avant le premier update
    void Start()
    {

    }

    // Le code a exécuter a chaque update
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Bouger le joueur vers l'avant
        transform.Translate(Vector3.forward * speed * Time.deltaTime * forwardInput);
        // Rotater le joueur
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);

        // Si la position x depasse 14 ou -14 (la limite de la plateforme)
        if (transform.position.x > xLimit)
        {
            transform.position = new Vector3(xLimit, 0, transform.position.y);

        }
        else if (transform.position.x < -xLimit)
        {

            transform.position = new Vector3(-xLimit, 0, transform.position.y);
        }

        // Si la position z depasse 23 ou -23 (la limite de la plateforme)
        if (transform.position.z > zLimit)
        {
            transform.position = new Vector3(zLimit, 0, transform.position.y);

        }
        else if (transform.position.z < -zLimit)
        {

            transform.position = new Vector3(-zLimit, 0, transform.position.y);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("space key was pressed");
            // Instantiate ( le prefab , sa position , sa rotation)
            Instantiate(projectilePrefab, transform.position + new Vector3(0, 0.5f, 0), transform.rotation);
        }

    }
}

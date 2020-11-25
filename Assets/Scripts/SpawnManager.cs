using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] germePrefabs;
    // Variables limitant la position à la pateforme de jeu
    private float spawnRangeX = 18;
    private float spawnPosZ = 0;

    private float startDelay = 0.4f;
    private float spawnInterval = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        // Appel la fonction personnalisé (nomFonction, Temps delais, L'interval d'apparition)
        InvokeRepeating("SpawnRandomGerme", startDelay, spawnInterval);

    }
    // Fonction Personnalisé
    void SpawnRandomGerme()
    {
        // Génère une position au hasard
        Vector3 spawnPos = new Vector3(Random.Range(spawnRangeX, -spawnRangeX), 0.2f, -23);

        // Génère un germe au hasard (grace au SPAWNPOS il s'ajoute a la fonction d'en haut pour générer une 
        // Position au hasard)
        int germeIndex = Random.Range(0, germePrefabs.Length);
        Instantiate(germePrefabs[germeIndex], spawnPos, germePrefabs[germeIndex].transform.rotation);
    }
}
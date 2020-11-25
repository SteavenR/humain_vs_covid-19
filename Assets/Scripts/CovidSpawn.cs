using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CovidSpawn : MonoBehaviour
{
    public GameObject[] covidPrefabs;
    // Variable limitant la position à la pateforme du jeu
    private float spawnRangeX = 18;
    private float spawnPosZ = 23;

    // Variables qui génère l'apparition des boules de Covid-19
    private float startDelay = 2;
    private float spawnInterval = 3;
    // Start is called before the first frame update
    void Start()
    {
        // Appel la fonction personnalisé (nomFonction, Temps delais, L'interval d'apparition)
        InvokeRepeating("SpawnRandomCovid", startDelay, spawnInterval);

    }
    // Fonction Personnalisé
    void SpawnRandomCovid()
    {
        // Génère une position au hasard
        Vector3 spawnPos = new Vector3(Random.Range(spawnRangeX, -spawnRangeX), 0, -23);

        // Génère une boule de Covid-19 au hasard (grace au SPAWNPOS il s'ajoute a la fonction d'en haut pour générer une 
        // Position au hasard.)
        int covidIndex = Random.Range(0, covidPrefabs.Length);
        Instantiate(covidPrefabs[covidIndex], spawnPos, covidPrefabs[covidIndex].transform.rotation);
    }
}
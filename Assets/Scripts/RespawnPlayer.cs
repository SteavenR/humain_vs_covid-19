using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPlayer : MonoBehaviour
{

    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        // Si le joueur tombe hors de la map, il sera téléporté à son point de départ
        player.transform.position = respawnPoint.transform.position;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Vie maximale du joueur
    public int maxHealth = 200;
    // Vie actuelle du joueur
    public int currentHealth;

    // Barre de vie
    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        // Au départ, le joueur possède le niveau de vie maximale
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        // Lorsque la touche "Espace" est appuyé, 200 - 1
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(1);
        }
    }

    void TakeDamage(int damage)
        // Donne l'effet de perdre de la vie lorsque la touche "Espace" est appuyé
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }
}
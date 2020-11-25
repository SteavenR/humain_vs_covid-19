using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    // Variables de la barre de vie
    public Slider slider;
    public Gradient gradient;
    public Image fill;

    public void SetMaxHealth(int health)
    {
        // Barre bleu lorsque le jeu est partie
        slider.maxValue = health;
        slider.value = health;

        // Couleur allant du bleu pâle au bleu foncé
        fill.color = gradient.Evaluate(1f);
    }
    public void SetHealth(int health)
    {
        // Le niveau de vie va selon le slider
        slider.value = health;

        // La couleur du slider est gradient
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}

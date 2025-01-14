using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : Module
{
    public int maxHealth;
    public int currentHealth;
    public Image fillBar;

    private void Start()
    {
        currentHealth = maxHealth;
        UpdateView();
    }

    public void TakeDamage(int damage)
    {
        Debug.Log($"{entity.gameObject.name} took damage: {damage}");
        currentHealth -= damage;
        if (currentHealth <= 0) Destroy(entity.gameObject);
        UpdateView();
    }
    public void Heal(int heal)
    {
    }

    public void UpdateView()
    {
        fillBar.fillAmount = (float)currentHealth / (float)maxHealth;
    }
}
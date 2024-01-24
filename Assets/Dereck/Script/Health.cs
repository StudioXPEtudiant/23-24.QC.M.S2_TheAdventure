using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] private int maxHealth = 5;
    [SerializeField] private UnityEvent healthDecreased;
    [SerializeField] private UnityEvent healthReachedMin;
    private int _health;
    public Image healthBar;

    private void Awake()
    {
        _health = maxHealth;
    }


    public void Decrease(int damage)
    {
        if (_health == 0 || damage <= 0)
            return;
        _health -= damage;
        healthDecreased.Invoke();
        if (_health < 0)
            _health = 0;

        if (_health == 0)
            healthReachedMin.Invoke();
        healthBar.fillAmount = _health / maxHealth;
    }
    public void HealthRefill()
    {
        _health = maxHealth;
        healthBar.fillAmount = _health / maxHealth;

    }
}

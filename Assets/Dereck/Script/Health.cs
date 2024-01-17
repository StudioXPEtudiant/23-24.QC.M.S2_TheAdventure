using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField] private int maxHealth = 5;
    [SerializeField] private UnityEvent healthDecreased;
    [SerializeField] private UnityEvent healthReachedMin;
    private int _health;

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
    }
    public void HealthRefill()
    {
        _health = maxHealth;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int _health;
    public int _maxHealth = 100;

    public healthBar _HealthBar;

    void Start()
    {
        _health = _maxHealth;
        _HealthBar.setMaxHealth(_health);
    }

    void Update()
    {

    }

    public int getHealth() {
        return _health;
    }

    public void damage(int damageAmount) {
        if (_health - damageAmount <= 0) {
            _health = 0;
            _HealthBar.setHealth(_health);
            return;
        }
        _health -= damageAmount;
        _HealthBar.setHealth(_health);
    }

    public void heal(int healAmount) {
        if (_health + healAmount > 100) {
            _health = 100;
            return;
        }
        _health += healAmount;
    }
}

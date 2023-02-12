using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private int _health;
    // Start is called before the first frame update
    void Start()
    {
        _health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int getHealth() {
        return _health;
    }

    public void damage(int damageAmount) {
        if (_health - damageAmount <= 0) {
            _health = 0;
            return;
        }
        _health -= damageAmount;
        print(_health);
    }

    public void heal(int healAmount) {
        if (_health + healAmount > 100) {
            _health = 100;
            return;
        }
        _health += healAmount;
    }
}

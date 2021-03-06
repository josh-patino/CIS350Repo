/*
* Josh Patino 
* Step 1 A6
* example weapon class
*/ 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public int damageBonus; 
    public Enemy enemyHoldingWeapon; 
    public void Awake()
    {
        enemyHoldingWeapon = gameObject.GetComponent<Enemy>(); 
        EnemyEatsWeapon(enemyHoldingWeapon); 
    }

    protected void EnemyEatsWeapon(Enemy enemy)
    {
        Debug.Log("Enemy eats weapon"); 
    }

    public void Recharge()
    {
        Debug.Log("recharging weapon"); 
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

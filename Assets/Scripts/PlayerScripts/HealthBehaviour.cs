using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBehaviour : MonoBehaviour
{
    public HealthBar healthbar;
    public int Maxhp = 100;
    public int currenthp;
    // Start is called before the first frame update
    void Start()
    {
        currenthp = Maxhp;
        healthbar.SetMaxHealth(Maxhp);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage(int Damage)
    {
        currenthp -= Damage;
        if(currenthp <= 0)
        {
            currenthp = 0;
        }
        healthbar.SetHealth(currenthp);
    }
    public void Heal(int heal)
    {
        currenthp += heal;
        if(currenthp >= Maxhp)
        {
            currenthp = Maxhp;
        }
        healthbar.SetHealth(currenthp);
    }
}

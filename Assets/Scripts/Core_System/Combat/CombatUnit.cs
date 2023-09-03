using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatUnit : MonoBehaviour
{

    // attack status
    public int attack_damage;
    public float attack_damage_bonus;
    public int attack_speed;
    public float attack_speed_bonus;
    public int attack_range;
    public float attack_range_bonus;

    // defence status
    public int max_health;
    public float max_health_bonus;
    public int curr_health;
    public float heal_receive;

    // move status
    public int move_speed;
    public float move_speed_bonus;

    // special
    public bool interact;           // click to trigger special ability
    public AttackType attack_type;  // the type of normal attack

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
 
}

public enum AttackType
{
    normal,
    heal,
    range,
    link
}
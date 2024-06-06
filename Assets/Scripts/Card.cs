using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    [SerializeField] public int cost = 0;
    public string type;
    public int power;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    int getPower() { return power; }
    string getType() { return type; }

    void setPower(int powerInput) {power = powerInput;}
    void setType(string typeInput) { this.type = typeInput;}

    void upgradeCard()
    {
        power += 1;
    }
}

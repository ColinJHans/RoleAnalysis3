using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] public int health = 3;
    [SerializeField] public int startMana = 1;
    public int currentMana;
    public int turnMana;
    [SerializeField] public int maxMana = 5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

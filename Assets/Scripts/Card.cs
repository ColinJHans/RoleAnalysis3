using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Card : MonoBehaviour
{
    [SerializeField] public int cost = 0;
    [SerializeField] public TextMeshProUGUI numText;
    private string type;
    public string Type { get { return type;} set { type = value;} }
    [SerializeField] private int power;
    public int Power { get { return power; } set { power = value; } }
    [SerializeField] public GameObject container;
    void Start()
    {
        numText.text = Power.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void upgradeCard()
    {
        this.power += 1;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscardPile : MonoBehaviour
{
    List<Card> pile;
    public List<Card> Pile { get { return pile; } }
    // Start is called before the first frame update
    void Start()
    {
        pile = new List<Card>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void addToDiscard(Card played)
    {
        pile.Add(played);
    }
}

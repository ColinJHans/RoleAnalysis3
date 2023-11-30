using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCards : MonoBehaviour
{
    [SerializeField] GameObject card;
    [SerializeField] GameObject playerArea;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClick()
    {
        for (int i = 0; i < 7; i++)
        {
            GameObject newCard = Instantiate(card, new Vector2(0,0), Quaternion.identity);
            newCard.transform.SetParent(playerArea.transform, false);
        }
    }
}

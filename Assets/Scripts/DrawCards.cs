using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCards : MonoBehaviour
{
    [SerializeField] GameObject card1;
    [SerializeField] GameObject card2;
    [SerializeField] GameObject card3;
    [SerializeField] GameObject playerArea;

    public void onClick()
    {
        GameManager.instance.addMana();
        GameManager.instance.manaText.SetText("Mana: " + GameManager.instance.turnMana.ToString());
        for (int i = 0; i < 2; i++)
        {
            GameObject newCard = Instantiate(card1, new Vector2(0,0), Quaternion.identity);
            newCard.transform.SetParent(playerArea.transform, false);
        }
        for (int i = 0; i < 2; i++)
        {
            GameObject newCard = Instantiate(card2, new Vector2(0, 0), Quaternion.identity);
            newCard.transform.SetParent(playerArea.transform, false);
        }
        for (int i = 0; i < 2; i++)
        {
            GameObject newCard = Instantiate(card3, new Vector2(0, 0), Quaternion.identity);
            newCard.transform.SetParent(playerArea.transform, false);
        }
    }
}

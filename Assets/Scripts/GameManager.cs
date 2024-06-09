using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] TextMeshProUGUI healthText;
    [SerializeField] TextMeshProUGUI turnText;
    [SerializeField] TextMeshProUGUI endGameText;
    [SerializeField] TextMeshProUGUI fullHandText;

    [SerializeField] GameObject chaCard;
    [SerializeField] GameObject couCard;
    [SerializeField] GameObject cleCard;
    [SerializeField] GameObject creCard;

    [SerializeField] PlayerArea playerArea;
    [SerializeField] GameObject ConvoTopic;
    [SerializeField] PlayerDeckScript deckContainer;
    [SerializeField] Dropzone dropzone;
    [SerializeField] DiscardPile discard;
    
    [SerializeField] public int health = 3;
    [SerializeField] int missingCards;
    [SerializeField] Enemy enemy;
    [SerializeField] GameObject enemyAttackPos;
    [SerializeField] GameObject enemyStartPos;
    private int turncount = 0;


    public List<string> categories = new List<string>() {"Cha", "Cou", "Cle", "Cre" }; 
    private bool justAttacked = false;
    private void Awake()
    {
        instance = this;
        setConvoStart();
        
    }
    private void Start()
    {
        
    }
    public void setConvoStart()
    {
        
        
    }
    public void setTopicGM(string type, ConvoTopic topic)
    {
        topic.setTopic(type);
    }
    public void updateHealthText()
    {
        healthText.text = ("Health: " + health.ToString());
    }
    public void OnEndTurn()
    {
        turncount++;
        turnText.SetText("Turns Passed: " + turncount.ToString());
        //checks if the players hand has more than 5 cards if so doesnt draw
        if (playerArea.CardsInHand.Count < 5 && deckContainer.Deck.Count > 0) 
        {            
            missingCards = 5 - playerArea.CardsInHand.Count;
            fullHandText.enabled = false;
            for (int i = 0; i < missingCards; i++)
            {
                Card card = deckContainer.draw();
                deckContainer.removeCard(card);
                card.transform.SetParent(playerArea.transform);
                playerArea.AddCards(card);
            }           
        }
        else
        {
            fullHandText.enabled = true;
        }

        dropzone.scoreCard();
     }
}

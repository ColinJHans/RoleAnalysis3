using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] public TextMeshProUGUI manaText;
    [SerializeField] TextMeshProUGUI healthText;
    [SerializeField] TextMeshProUGUI turnText;
    [SerializeField] TextMeshProUGUI endGameText;
    
    [SerializeField] GameObject attackCard;
    [SerializeField] GameObject defenseCard;
    [SerializeField] GameObject chaCard;
    [SerializeField] GameObject couCard;
    [SerializeField] GameObject cleCard;
    [SerializeField] GameObject creCard;
    [SerializeField] GameObject manaCard;

    [SerializeField] GameObject playerArea;
    [SerializeField] GameObject ConvoTopic;
    
    [SerializeField] public int health = 3;
    [SerializeField] public int startMana = 1;

    [SerializeField] Enemy enemy;
    [SerializeField] GameObject enemyAttackPos;
    [SerializeField] GameObject enemyStartPos;
    private int turncount = 0;
    // current mana is start of turn mana
    public int currentMana = 1;
    // turn mana is mana that is spent during the turn
    public int turnMana = 1;
    [SerializeField] public int maxMana = 5;

    public List<string> categories = new List<string>() {"Cha", "Cou", "Cle", "Cre" }; 
    private bool justAttacked = false;
    private void Awake()
    {
        instance = this;
        setConvoStart();
        
    }
    public void setConvoStart()
    {
        
        
    }
    public void setTopicGM(string type, ConvoTopic topic)
    {
        topic.setTopic(type);
    }
    public void addMana()
    {
        turnMana++;
        manaText.text = "Mana: " + turnMana.ToString();
    }
    public void subtractMana(int cost)
    {
        turnMana -= cost;
        manaText.text = "Mana: " + turnMana.ToString();
    }
    public void updateHealthText()
    {
        healthText.text = ("Health: " + health.ToString());
    }
    public void OnEndTurn()
    {
        turncount++;
        turnText.SetText("Turns Passed: " + turncount.ToString());
        if (currentMana < maxMana)
        {
            currentMana++;
            turnMana = currentMana;
            manaText.text = "Mana: " + turnMana.ToString();
        }
        else
        {
            turnMana = currentMana;
        }
        int cardChoice = Random.Range(1, 4);
        if (cardChoice == 1 ) 
        {
            GameObject newCard = Instantiate(chaCard, new Vector2(0, 0), Quaternion.identity);
            newCard.transform.SetParent(playerArea.transform, false);
        }
        else if (cardChoice == 2 )
        {
            GameObject newCard = Instantiate(defenseCard, new Vector2(0, 0), Quaternion.identity);
            newCard.transform.SetParent(playerArea.transform, false);
        }
        else
        {
            GameObject newCard = Instantiate(manaCard, new Vector2(0, 0), Quaternion.identity);
            newCard.transform.SetParent(playerArea.transform, false);
        }
        if (!justAttacked) 
        {
            enemy.transform.position = enemyAttackPos.transform.position;
            health -= 1;
            updateHealthText();
            justAttacked = true;
        }
        else
        {
            enemy.transform.position = enemyStartPos.transform.position;
            justAttacked = false;
        }
        if (health == 0)
        {
            endGameText.SetText("You Lose!!!");
        }
        if (enemy.health == 0)
        {
            endGameText.SetText("You Win!!!");
        }
        
    }
}

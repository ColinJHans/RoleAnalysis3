using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Player player;
    [SerializeField] TextMeshProUGUI manaText;
    [SerializeField] TextMeshProUGUI healthText;
    [SerializeField] TextMeshProUGUI turnText;
    private int turncount = 0;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void OnEndTurn()
    {
        turncount++;
        turnText.SetText("Turns Passed: " + turncount.ToString());
        if (player.currentMana < player.maxMana)
        {
            player.currentMana++;
            player.turnMana = player.currentMana;
            manaText.text = "Mana: " + player.turnMana.ToString();
        }
        else
        {
            player.turnMana = player.currentMana;
        }

    }
}

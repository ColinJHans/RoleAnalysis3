using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ConvoTopic : MonoBehaviour
{
    [SerializeField] public string convoAttribute;
    [SerializeField] public int powerNum;
    [SerializeField] TextMeshProUGUI attributeText;
    [SerializeField] TextMeshProUGUI numText;
    
    [SerializeField] GameObject AttrIconContainer;
    SpriteRenderer iconRenderer;
    Sprite AttrIcon;
    [SerializeField] Sprite chaIcon;
    [SerializeField] Sprite cleIcon;
    [SerializeField] Sprite couIcon;
    [SerializeField] Sprite creIcon;
    void Start()
    {
        iconRenderer = AttrIconContainer.GetComponentInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setTopic(string topic)
    {
        convoAttribute = topic;
        attributeText.text = topic;
        setIcon();
    }
    public void setNum(int numInput)
    {
        powerNum = numInput;
        numText.text = numInput.ToString();
    }
    public void setIcon()
    {
        if (convoAttribute.ToLower() == "cha")
        {
            iconRenderer.sprite = chaIcon;
        }
        else if (convoAttribute.ToLower() == "cre")
        {
            iconRenderer.sprite = creIcon;
        }
        else if (convoAttribute.ToLower() == "cou")
        {
            iconRenderer.sprite = couIcon;
        }
        else if (convoAttribute.ToLower() == "cle")
        {
            iconRenderer.sprite = cleIcon;
        }
    }

    public int getPowerNum()
    {
        return powerNum;
    }
    public string getTopic()
    {
        return convoAttribute;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using TMPro;

public class CelciPlaytest : MonoBehaviour
{
    List<ConvoTopic> convoTopics;
    [SerializeField] ConvoTopic convoTopic1;
    [SerializeField] ConvoTopic convoTopic2;
    [SerializeField] ConvoTopic convoTopic3;

    [SerializeField] TextMeshProUGUI convoTextOutput;
    FileInfo source;
    protected StreamReader reader = null;
    string text = " ";
    float timer = 3f;
    void Start()
    {
        source = new FileInfo("Assets/Assets/loremipsum.txt");
        reader = source.OpenText();
        showTopics();
        readText();
    }

    // Update is called once per frame
    void Update()
    {
        Timer();
        print(timer);
        if (timer < 0f)
        {

            readText();
        }
    }

    void setTopics()
    {
        convoTopic1.setNum(7);
        convoTopic1.setTopic("Cha");
        //convoTopics.Add(convoTopic1);
        convoTopic2.setNum(8);
        convoTopic2.setTopic("Cre");
        //convoTopics.Add(convoTopic2);
        convoTopic3.setNum(9);
        convoTopic3.setTopic("Cle");
    }

    void showTopics()
    {
        setTopics();
    }
    void readText()
    {
        if (text != null)
        {            
            text = reader.ReadLine();
            print(text);
            convoTextOutput.text = text;            
        }
    }
    void Timer()
    {
        if (timer > 0f) { timer -= Time.deltaTime; }
        else { timer = 0f; }
        
    }
    void timerDone()
    {
        readText();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CelciPlaytest : MonoBehaviour
{
    List<ConvoTopic> convoTopics;
    [SerializeField] ConvoTopic convoTopic1;
    [SerializeField] ConvoTopic convoTopic2;
    [SerializeField] ConvoTopic convoTopic3;

    void Start()
    {
        showTopics();
    }

    // Update is called once per frame
    void Update()
    {
        
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
}

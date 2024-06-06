using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{
    [SerializeField] GameObject DropZone;
    [SerializeField] Card card;
    private bool isDragging= false;
    private GameObject startParent;
    private Vector2 startPos;
    private GameObject dropZone;
    private bool isOverDropZone;
    
    void Start()
    {
        dropZone = GameObject.Find("Dropzone");
    }

    void Update()
    {
     if (isDragging)
        {
            transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        }   
    }
    public void startDrag()
    {
        isDragging = true;
        startParent = transform.parent.gameObject;
        startPos = transform.position;


    }
    public void endDrag() 
    {
        isDragging = false;
        Debug.Log(this.gameObject.name);
        Debug.Log(dropZone);
        if (isOverDropZone)
        {
            transform.SetParent(dropZone.transform, false);
            if (this.gameObject.name == "AttackCard(Clone)")
            {
                Enemy.Instance.health--;
                Enemy.Instance.setHealthText();
            }
            if (this.gameObject.name == "ManaCard(Clone)")
            {
                GameManager.instance.addMana();
            }
            if (this.gameObject.name == "DefenseCard(Clone)")
            {
                GameManager.instance.health++;
                GameManager.instance.updateHealthText();
            }
        }
        else
        {
            transform.position = startPos;
            transform.SetParent(startParent.transform, false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isOverDropZone = true;
        dropZone = collision.gameObject;
        Debug.Log("HIT");
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        isOverDropZone= false;
        dropZone = null;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Littlegame5position : MonoBehaviour
{
    public bool isChongHe = false;      //是否與其對應的node重合

    private GameObject mouseObject;
    // Start is called before the first frame update
    void Start()
    {
        mouseObject = GameObject.Find("mouse");
    }

    //進入對應的position時,將isChongHe置爲true
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "position")
        {
            if (other.gameObject.name == mouseObject.GetComponent<Littlegame5>().puzzlename)
                isChongHe = true;
        }
    }
    //離開對應的positioin時,將isChongHe置爲false
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "position")
        {
            if (other.gameObject.name == mouseObject.GetComponent<Littlegame5>().puzzlename)
                isChongHe = false;
        }
    }

    //當自身被拖動到對應的position處並放開後
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "position")
        {
            if (other.gameObject.name == mouseObject.GetComponent<Littlegame5>().puzzlename && !mouseObject.GetComponent<Littlegame5>().isClicked)
            {
                this.transform.tag = "position";
                this.transform.position = other.transform.position;
            }

        }
    }
}

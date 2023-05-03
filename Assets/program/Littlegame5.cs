using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Littlegame5 : MonoBehaviour
{
    public string puzzlename = "position";
    public GameObject[] fragment;


    private bool isMouseDown = false;
    public bool isClicked = false;
    private bool overlap = false;
    private Vector3 oldposition;
    private GameObject target = null;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //使mouse始終跟着鼠標走
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1));
        isMouseDown = Input.GetMouseButton(0);      //鼠標左鍵按下時,isMouseDown爲true
        if (!isMouseDown && isClicked)
        {   //item被拖動過程中鼠標左鍵放開
            isClicked = false;
            if (!overlap)
                target.transform.position = oldposition;

        }
        //在item被拖動過程中保證其始終跟着mouse走,並時刻判定其是否與對應node重合
        if (isClicked)
        {
            target.transform.position = transform.position;
            overlap = target.GetComponent<Littlegame5position>().isChongHe;
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (isMouseDown && !isClicked && other.gameObject.tag == "puzzle")
        {
            isClicked = true;
            target = GameObject.Find(other.gameObject.name);
            oldposition = other.transform.position;
            puzzlename = "position_" + other.gameObject.name[7];
        }
    }
}

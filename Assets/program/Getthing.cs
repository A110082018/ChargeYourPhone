using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Getthing : MonoBehaviour
{

    public Image UI1;
    public Image UI2;
    public Image Key;
    public static bool Getkey = false;

    // Start is called before the first frame update
    void Start()
    {
        UI1.enabled = false;
        UI2.enabled = false;
        Key.enabled = false;

    }
    // Update is called once per frame
    void Update()
    {
        if(Littlegamefinal.finish ==true)
        {
            UI1.enabled = true;
        }
        if (Littlegame2final.finish2 == true)
        {
            UI2.enabled = true;
        }
        if (Littlegame3final.finish3 == true)
        {
            Key.enabled = true;
            Getkey = true;
        }

    }


}

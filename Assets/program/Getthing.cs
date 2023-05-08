using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Getthing : MonoBehaviour
{
    public static int count = 0; // 璸计竟
    public Image UI1;
    public Image UI2;
    public Image Key;
    public Image picture;
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
            // 糤璸计竟
            count++;
        }
        if (Littlegame2final.finish2 == true)
        {
            UI2.enabled = true;
            // 糤璸计竟
            count++;
        }
        if (Littlegame3final.finish3 == true)
        {
            Key.enabled = true;
            Getkey = true;
            // 糤璸计竟
            count++;
        }
        if (Littlegame5final.finish5 == true)
        {
            picture.enabled = true;
          
            // 糤璸计竟
            count++;
        }

    }


}

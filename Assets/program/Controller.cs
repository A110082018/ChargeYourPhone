using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public GameObject littlegameplay;
    public GameObject littlecamera;
    public GameObject littlegameplay2;
    public GameObject littlecamera2;
    public GameObject littlegameplay3;
    public GameObject littlecamera3;
    public GameObject littlegameplay4;
    public GameObject littlecamera4;
    public GameObject player;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Littlegamefinal.finish == true)
        {
            player.SetActive(true);
            Ray1.littlegameplayON = false;
            littlegameplay.SetActive(false);
            littlecamera.SetActive(false);
        }

        if (Littlegame2final.finish2 == true)
        {
            player.SetActive(true);
            Ray1.littlegameplayON = false;
            littlegameplay2.SetActive(false);
            littlecamera2.SetActive(false);
        }
        if (Littlegame3final.finish3 == true)
        {
            player.SetActive(true);
            Ray1.littlegameplayON = false;
            littlegameplay3.SetActive(false);
            littlecamera3.SetActive(false);
        }

        if (Littlegame4final.finish4 == true)
        {
            player.SetActive(true);
            Ray1.littlegameplayON = false;
            littlegameplay4.SetActive(false);
            littlecamera4.SetActive(false);
        }


    }
}

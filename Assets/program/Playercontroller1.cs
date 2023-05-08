using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller1 : MonoBehaviour
{
    public GameObject player;
    public static bool littlegameplayON = false;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame

    void Update()
    {

        if (littlegameplayON == true)
        {
            player.SetActive(false);
        }

        if (littlegameplayON == false)
        {
            player.SetActive(true);
        }

    }
}


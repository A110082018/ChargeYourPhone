using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pictureUI : MonoBehaviour
{
    public GameObject picture1;
    public GameObject picture2;
    // Start is called before the first frame update
    void Start()
    {
        picture1.SetActive(false);
        picture2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Controller.Getkey == true)
        {
            picture1.SetActive(true);
            picture2.SetActive(true);
        }
    }
}

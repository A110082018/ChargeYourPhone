using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Littlegame5final : MonoBehaviour
{

    public static bool finish5 = false;
    public GameObject picture;
    // Start is called before the first frame update
    void Start()
    {
        picture.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Littlegame5.count == 6)
        {
            picture.SetActive(true);
            Invoke("finish", 3);
        }

    }
    private void finish()
    {
        finish5 = true;
        Debug.Log("finish");
        

    }

}

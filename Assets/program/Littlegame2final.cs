using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Littlegame2final : MonoBehaviour
{

    public static bool finish2 = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        finish2 = true;
        // Time.timeScale = 1;
       


    }
}

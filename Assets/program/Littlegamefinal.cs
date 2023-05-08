using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Littlegamefinal : MonoBehaviour
{
    public  static bool finish = false;


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
        finish = true;
       // Time.timeScale = 1;
       
    }

}

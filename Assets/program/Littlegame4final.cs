using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Littlegame4final : MonoBehaviour
{

    

    public static bool finish4 = false; // 标记是否被触发

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag =="key")
        {
            gameObject.SetActive(false);
        }
    }
}

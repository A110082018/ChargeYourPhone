using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ray1 : MonoBehaviour
{
    public static bool littlegameplayON = false;
    public  GameObject littlegameplay;
    public  GameObject littlecamera;
    public GameObject littlegameplay2;
    public GameObject littlecamera2;
    public  GameObject player;


    private void Start()
    {
        littlegameplay.SetActive(false);
        littlecamera.SetActive(false);
        littlegameplay2.SetActive(false);
        littlecamera2.SetActive(false);
        player.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        //¿Ã¹õ®g½u

        RaycastHit hit;
      
        if (Input.GetMouseButtonDown(0) && Physics.Raycast(ray, out hit)&& hit.collider.gameObject.name == "Bed_TeddyBear")
        {
            player.SetActive(false);
            littlegameplayON = true;
            littlegameplay.SetActive(true);
            littlecamera.SetActive(true);
            Debug.Log(hit.transform.name);
            Debug.DrawLine(Camera.main.transform.position, hit.transform.position, Color.red, 0.5f, true);
                  
        }
        if (Input.GetMouseButtonDown(0) && Physics.Raycast(ray, out hit) && hit.collider.gameObject.name == "item2")
        {
            player.SetActive(false);
            littlegameplayON = true;
            littlegameplay2.SetActive(true);
            littlecamera2.SetActive(true);
            //Debug.Log(hit.transform.name);
            //Debug.DrawLine(Camera.main.transform.position, hit.transform.position, Color.red, 0.5f, true);

        }
    }
}

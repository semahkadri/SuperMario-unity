using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Coins : MonoBehaviour
{
    public GameObject prefab;

    private void Start()
    {
        GameObject go = Instantiate(prefab, new Vector3(3.8f, -2.9f, 0.68f), Quaternion.identity);
        GameObject go1 = Instantiate(prefab, new Vector3(3.8f + 2, -2.9f, 0.68f), Quaternion.identity);


        
                for (int i = 0; i < 6; i++)
                {
                    GameObject go2 = Instantiate(prefab, new Vector3(23.1f+(i*2), -0.9f, 0.68f), Quaternion.identity);
                }


                for (int i = 0; i < 8; i++)
                {
                    GameObject go2 = Instantiate(prefab, new Vector3(49.1f + (i * 2), -0.9f, 0.68f), Quaternion.identity);
                }

                for (int i = 0; i < 5; i++)
                {
                    GameObject go2 = Instantiate(prefab, new Vector3(83.5f + (i * 2), -0.9f, 0.68f), Quaternion.identity);
                }

                for (int i = 0; i < 5; i++)
                {
                    GameObject go2 = Instantiate(prefab, new Vector3(156.4f + (i * 2), -5f, 0.68f), Quaternion.identity);
                }

                for (int i = 0; i < 5; i++)
                {
                    GameObject go2 = Instantiate(prefab, new Vector3(197.7f + (i * 2), -5f, 0.68f), Quaternion.identity);
                }


                for (int i = 0; i < 5; i++)
                {
                    GameObject go2 = Instantiate(prefab, new Vector3(238.6f + (i * 2), -5f, 0.68f), Quaternion.identity);
                }


                for (int i = 0; i < 5; i++)
                {
                    GameObject go2 = Instantiate(prefab, new Vector3(266.7f + (i * 2), -1.1f, 0.68f), Quaternion.identity);
                }
                

       
    }





}
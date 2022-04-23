using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDestroy : MonoBehaviour
{
    public GameObject DestroyPoint;
    void Start()
    {
        DestroyPoint = GameObject.Find("DestroyPoint");
    }

    private void Update()
    {
        if(transform.position.x < DestroyPoint.transform.position.x)
        {
            //Destroy(gameObject);

            gameObject.SetActive(false);
        }
    }

}

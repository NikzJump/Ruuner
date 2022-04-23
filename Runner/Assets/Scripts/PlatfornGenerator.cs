using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatfornGenerator : MonoBehaviour
{
    public GameObject platform;
    public Transform GeneratorPoint;
    public GameObject[] platforms;

    public float distanceBeetween;
    private float platformWidth;
    public float distanseMin;
    public float distanceMax;
    float[] platformsWidth;
    float minHeight;
    public Transform maxHeightPoint;
    float Heught;
    float maxHeight;
    public float maxHeightChange;
    float heightChange;
    private float distansePlus;
    private float distansePlus2;


    int platformSelector;

    //public PlatformManager platformM;

    private void Start()
    {
        //platformWidth = GetComponent<BoxCollider2D>().size.x;
        platformsWidth = new float[platforms.Length];

        for (int i = 0; i < platforms.Length; i++)
        {
            platformsWidth[i] = platforms[i].GetComponent<BoxCollider2D>().size.x;
        }

        minHeight = transform.position.y;
        maxHeight = maxHeightPoint.position.y;

        distansePlus = 0.001f;
        distansePlus2 = 0.0001f;
    }

    private void Update()
    {
        if (transform.position.x < GeneratorPoint.transform.position.x)
        {
            platformSelector = Random.Range(0, platforms.Length);
            if(heightChange > maxHeight)
            {
                heightChange = maxHeight;
            }
            else if(heightChange < minHeight)
            {
                heightChange = minHeight;
            }

            heightChange = transform.position.y + Random.Range(maxHeightChange, -maxHeightChange);

            distanceBeetween = Random.Range(distanseMin, distanceMax);

            transform.position = new Vector3(transform.position.x + platformsWidth[platformSelector] + distanceBeetween, heightChange, transform.position.z);

            Instantiate(/*platform*/platforms[platformSelector], transform.position, transform.rotation);
            //GameObject newPlatform = platformM.GetPlatform();
            //newPlatform.transform.position = transform.position;
            //newPlatform.transform.rotation = transform.rotation;
            //newPlatform.SetActive(true);
        }


    }

    private void FixedUpdate()
    {
        distanceMax += distansePlus;
        distanseMin += distansePlus2;
    }
}

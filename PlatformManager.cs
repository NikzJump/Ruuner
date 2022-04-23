using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    public GameObject Platform;
    public int PlatformAmount;
    List<GameObject> platforms;

    private void Start()
    {
        platforms = new List<GameObject>();

        for (int i = 0; i < PlatformAmount; i++)
        {
            GameObject obj = Instantiate(Platform);
            obj.SetActive(false);
            platforms.Add(obj);
        }
    }

    public GameObject GetPlatform()
    {
        for (int i = 0; i < platforms.Count; i++)
        {
            if (!platforms[i].activeInHierarchy)
            {
                return platforms[i];
            }
        }
        GameObject obj = Instantiate(Platform);
        obj.SetActive(false);
        platforms.Add(obj);
        return obj;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteRoad : MonoBehaviour
{
    public GameObject[] Road = new GameObject[2];
    const float RoadLength = 100f; //length of roads

    const float RoadSpeed = 100f; //speed to scroll roads at
    void Update()
    {
        foreach (GameObject Road in Road)
        {
            Vector3 newRoadPos = Road.transform.position;
            newRoadPos.z -= RoadSpeed * Time.deltaTime;
            if (newRoadPos.z < -RoadLength / 2)
            {
                newRoadPos.z += RoadLength;
            }
            Road.transform.position = newRoadPos;
        }
    }
}

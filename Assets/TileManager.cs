using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{

    public GameObject[] tilePrefabs;
    private Transform playerTransform;
    private float spawnZ = 703.0f;
    private float spawnY = 30.0f;
    private float spawnX = 400.0f;
    private float tileLength = 2797.0f;
    private int amnTilesOnScreen = 3;
    private int lastPrefabIndex = 0;

    private float safeZone = 100.0f;
    private List<GameObject> activeTiles;

    // Start is called before the first frame update
    private void Start()
    {
        activeTiles = new List<GameObject>();
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

        for(int i = 0; i < amnTilesOnScreen; i++)
        {
            if (i < 2)
                SpawnTile(0);              
            else
                SpawnTile();
                SpawnTile();
        }
    }

    // Update is called once per frame
    private void Update()
    {
        if(playerTransform.position.z - safeZone > (spawnZ - amnTilesOnScreen * tileLength))
        {
            SpawnTile();
            DeleteTile();
        }
    }

    private void SpawnTile(int prefabIndex = -1)
    {
        GameObject go;
        if (prefabIndex == -1)
            go = Instantiate(tilePrefabs[RandomPrefabIndex()]) as GameObject;
        else
            go = Instantiate(tilePrefabs[prefabIndex]) as GameObject;

        go.transform.SetParent(transform);
        go.transform.position = Vector3.forward * spawnZ + Vector3.down * spawnY + Vector3.right* spawnX;
        spawnZ += tileLength;
        activeTiles.Add(go);
    }

    private void DeleteTile()
    {
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
    }

    private int RandomPrefabIndex()
    {
        if (tilePrefabs.Length <= 1)
            return 0;

        int randomIndex = lastPrefabIndex;
        while(randomIndex == lastPrefabIndex)
        {
            randomIndex = Random.Range(0, tilePrefabs.Length);
        }

        lastPrefabIndex = randomIndex;
        return randomIndex;
    }

}

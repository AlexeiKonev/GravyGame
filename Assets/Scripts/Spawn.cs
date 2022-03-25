using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawn : MonoBehaviour
{
    [SerializeField] List<GameObject> platformSpawnList = new List<GameObject>();
    [SerializeField] Transform spawnPosition;
    [SerializeField] float spawnDelay=3f;
    private void Start()
    {
        Spawner();
        Instantiate(platformSpawnList[0], spawnPosition.position, spawnPosition.rotation);
    }
    private void FixedUpdate()
    {
       
    }
    public void Spawner()
    {
        int randomIndexPlatform = Random.Range(0, platformSpawnList.Count );

         
            Instantiate(platformSpawnList[randomIndexPlatform], spawnPosition.position, spawnPosition.rotation);
            StartCoroutine(WaitSpawn());
        
    }
    private IEnumerator WaitSpawn()
    {

        yield return new WaitForSeconds(spawnDelay);
        Spawner();
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{   
    public GameObject prefab;
    public int spawnRounds;
    public int spawnAmount;
    public float spawnInterval;

    private void Start()
    {
        StartCoroutine(SpawnSequence());
    }
    public void CreateGameObject(Vector3 position)
    {
        Instantiate(prefab, position, Quaternion.identity);
    }

    private IEnumerator SpawnSequence()
    {
         
        for (int i = 0; i < spawnRounds; i++)
        {
            int rowCount = (int)Mathf.Sqrt(spawnAmount);

            for (var x = 0; x < rowCount; x++)
            {
                for (var y = 0; y < rowCount; y++)
                {
                    var position = new Vector3(x * 10, 0, y * 10);
                    CreateGameObject(position);
                }
            }
            for (int frame = 0; frame < 50; frame++)
                yield return new WaitForEndOfFrame();
        }
        Application.Quit();
    }

}

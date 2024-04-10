using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointManager : MonoBehaviour
{
    public Transform[] spawnPoints;
    int count;
    int currentIndex;

    private void Start()
    {
        count = spawnPoints.Length;
        currentIndex = -1;
    }

    public Vector3 SelectRandomSpawnpoint(bool isImitation = false)
    {
        if (!isImitation)
        {
            int rnd = Random.Range(0, spawnPoints.Length);
            return spawnPoints[rnd].position;
        }
        else
        {
            currentIndex++;
            if (currentIndex >= count)
            {
                currentIndex = 0;
                Time.timeScale = 0;
            }
            return spawnPoints[currentIndex].position;
        }
    }

    GUIStyle style = new GUIStyle();
    private void OnGUI()
    {
        style.fontSize = 50;
        GUILayout.Label("Count: " + currentIndex,style);
    }
}

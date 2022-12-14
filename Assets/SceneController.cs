using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    private GameObject enemy;
    // Update is called once per frame
    void Update()
    {
        if(enemy == null)
        {
            enemy = Instantiate(enemyPrefab) as GameObject;
            float posx = Random.Range(-20, 20);
            float posz = Random.Range(-20, 20);
            enemy.transform.position = new Vector3((int)posx, 4, (int)posz);
            float angle = Random.Range(0, 360);
            enemy.transform.Rotate(0, angle, 0);
        }
    }
}

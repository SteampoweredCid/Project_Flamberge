using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTimer : MonoBehaviour
{
	public Transform enemySpawn;
	public GameObject enemy;
	float timer = 0f;
    
    void Update()
    {
         // timer += Time.deltaTime;
         // Debug.Log(timer);   
        
         // if (timer >= 2){
         	GameObject Enemy = Instantiate(enemy, enemySpawn.position, enemySpawn.rotation);
         	Enemy.transform.parent = gameObject.transform;
         // }


         // if (timer == 10){
         // 	//Instantiate(Enemy, enemySpawn.position, enemySpawn.rotation);
         // }
    }
}

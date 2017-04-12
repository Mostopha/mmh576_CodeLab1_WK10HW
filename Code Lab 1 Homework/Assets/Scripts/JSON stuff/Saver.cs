using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saver : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject[] asteroids = GameObject.FindGameObjectsWithTag("Asteroid");
        AsteriodData[] ad2 = new AsteriodData[asteroids.Length];

		


        for (int i = 0; i < asteroids.Length; i++)
        {
            Vector3 pos = asteroids[i].transform.position;
            Vector3 scale = asteroids[i].transform.localScale;

            ad2[i] = new AsteriodData(pos, scale);
        }


        foreach (AsteriodData asteriodInfo in ad2)
        {
            asteriodInfo.SaveToJsonArray("AllAsteriods.txt");
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

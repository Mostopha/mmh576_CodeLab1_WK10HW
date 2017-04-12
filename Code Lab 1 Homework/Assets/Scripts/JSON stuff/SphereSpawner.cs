using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;

public class SphereSpawner : MonoBehaviour {

    public Vector3 ballTransform;
    public Vector3 ballScale;

   // AsteriodData[] ad2 = new AsteriodData[10];

    // Use this for initialization
    void Start () {
        JSONArray ballPos = UtilScript.ReadJSONFromFile(Application.dataPath, "AllAsteriods.txt") as JSONArray;
        print(ballPos);

        

        for (int i=0; i< ballPos.Count; i++)
        {
            ballTransform = new Vector3(ballPos[i]["xPos"].AsFloat, ballPos[i]["yPos"].AsFloat, ballPos[i]["zPos"].AsFloat);
            print(ballTransform);

         

            ballScale = new Vector3(ballPos[i]["xScale"].AsFloat, ballPos[i]["yScale"].AsFloat, ballPos[i]["zScale"].AsFloat);
            print(ballScale);
           

            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphere.transform.position = ballTransform;
            sphere.transform.localScale = ballScale;
        }

        //AsteroidData loadAD = new AsteroidData("Asteroid.txt");

        //GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        //sphere.transform.position = loadAD.position;
        //sphere.transform.localScale = loadAD.scale;
    
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

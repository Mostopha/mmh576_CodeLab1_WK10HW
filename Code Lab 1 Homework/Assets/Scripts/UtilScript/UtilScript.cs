using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using SimpleJSON;

public class UtilScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        //comment out line 437-440 in simplejson.cs
        //then click re-import all
        //open test_unity script comment ot test function and 46-58 csharp script
        //reimport again
    }


    public static void WriteJSONtoFile(string path, string fileName, JSONClass json)
    {
        WriteStringToFile(path, fileName, json.ToString());
    }


    //created another contructor for WriteJSONToFile that takes JSONarray as an argument
    public static void WriteJSONtoFile(string path, string fileName, JSONArray json)
    {
        WriteStringToFile(path, fileName, json.ToString());
    }

    public static void WriteStringToFile(string path, string fileName, string content)
    {
        StreamWriter sw = new StreamWriter(path + "/" + fileName);
        sw.Write(content);
        sw.Close();
    }

    public static JSONNode ReadJSONFromFile(string path, string fileName)
    {
        string result = UtilScript.ReadStringFromFile(path, fileName);

        JSONNode readJSON = JSON.Parse(result);

        return readJSON;
    }

    public static string ReadStringFromFile(string path, string fileName)
    {
        StreamReader sr = new StreamReader(path + "/" + fileName);

        string results = sr.ReadToEnd();

        sr.Close();

        return results;
    }

    public static Vector3 CloneVector3(Vector3 vec)
    {
        return new Vector3(vec.x, vec.y, vec.z);
    }

    public static Vector3 CloneModVector3(
        Vector3 vec,
        float xMod,
        float yMod,
        float zMod)
    {
        return new Vector3(
            vec.x + xMod,
            vec.y + yMod,
            vec.z + zMod);
    }
}
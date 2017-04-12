using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;

public class AsteriodData
{


    public Vector3 position;
    public Vector3 scale;

    private static JSONArray jArray = new JSONArray();

    private const string POS_X = "xPos";
    private const string POS_Y = "yPos";
    private const string POS_Z = "zPos";

    private const string SCALE_X = "xScale";
    private const string SCALE_Y = "yScale";
    private const string SCALE_Z = "zScale";

    public AsteriodData(string fileName)
    {
        JSONNode jason = UtilScript.ReadJSONFromFile(Application.dataPath, fileName);

        position = new Vector3(
            jason[POS_X].AsFloat,
            jason[POS_Y].AsFloat,
            jason[POS_Z].AsFloat);

        scale = new Vector3(
            jason[SCALE_X].AsFloat,
            jason[SCALE_Y].AsFloat,
            jason[SCALE_Z].AsFloat);

    }

    public AsteriodData(Vector3 position, Vector3 scale)
    {
        this.position = position;
        this.scale = scale;

    }

    public JSONClass ToJSON()
    {
        JSONClass json = new JSONClass();

        json[POS_X].AsFloat = position.x;
        json[POS_Y].AsFloat = position.y;
        json[POS_Z].AsFloat = position.z;

        json[SCALE_X].AsFloat = scale.x;
        json[SCALE_Y].AsFloat = scale.y;
        json[SCALE_Z].AsFloat = scale.z;

        return json;
    }

    public void Save(string fileName)
    {
        JSONClass json = ToJSON();

        UtilScript.WriteJSONtoFile(Application.dataPath, fileName, json);
    }

    //Save each class to an array
    public void SaveToJsonArray(string fileName)
    {
        //Convert the current asteriod data to json txt
        JSONClass json = ToJSON();

        //Add that text to our json array
        jArray.Add(json);

        //write the jsonArray data to file(check utils scripts)
        UtilScript.WriteJSONtoFile(Application.dataPath, fileName, jArray);

    }



}
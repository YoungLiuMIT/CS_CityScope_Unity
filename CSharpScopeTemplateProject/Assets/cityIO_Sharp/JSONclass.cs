﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary> 
/// class start 
/// </summary>


public enum Brick { RL = 0, RM = 1, RS = 2, OL = 3, OM = 4, OS = 5, ROAD = 6, PARK = 7, PARKING = 8, STREET = 9, INVALID = -1, MASK = -2 };

[System.Serializable]  // have to have this in every JSON class!
public class Grid
{
    public int type;
    public int x;
    public int y;
    public int rot;
}

[System.Serializable] // have to have this in every JSON class!
public class Objects
{
    public float slider1;
    public int toggle1;
    public int toggle2;
    public int toggle3;
    public int toggle4;
    public int dockID;
    public int dockRotation;
    public int IDMax;
    public List<int> density;
    public int pop_young;
    public int pop_mid;
    public int pop_old;
}

[System.Serializable]// have to have this in every JSON class!
public class Table
{
    public List<Grid> grid;
    public Objects objects;
    public string id;
    public long timestamp;

    public static Table CreateFromJSON(string jsonString)
    { // static function that returns Table which holds Class objects 
        return JsonUtility.FromJson<Table>(jsonString);
    }

	public static Table CreateFromDecoder()
	{
		int[,] currIds = Scanners.GetCurrentIds ();
		Table table = new Table ();

		if ((int)(currIds.Length) <= 1) {
			Debug.Log ("Empty dictionary.");
		}
//		for (int i = 0; i < currIds.GetLength(0); i++) {
//			for (int j = 0; j < currIds.GetLength(1); j++) {
//				if (currIds [i, j] >= 0)
//					matrix += " ";
//				matrix += currIds [i, j] + "";
//				if (currIds [i, j] >= 0)
//					matrix += " ";
//			}
//			matrix += "\n";
//		}
//		Debug.Log (matrix);

		return table;
	}
}

/// <summary> class end </summary>
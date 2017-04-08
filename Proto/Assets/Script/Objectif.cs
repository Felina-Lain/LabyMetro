using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Objectif : MonoBehaviour {

	public static List<WayPoint> stations;

	// Use this for initialization
	void Start () {

		GameObject canvas = GameObject.Find ("Canvas");
		stations = new List<WayPoint>();
		AddAllStations();

		WayPoint _station_to_go = stations [Random.Range (0, stations.Count)];
		canvas.GetComponentInChildren<Text> ().text = "Vous voulez\naller à : " + _station_to_go.GetComponentInChildren<TextMesh> ().text;
		canvas.GetComponentInChildren<Text> ().enabled = false;


		foreach(WayPoint item in stations){

			foreach(Transform child in item.transform)
			{
				child.transform.gameObject.SetActive(false);
			}

		}

		List<WayPoint> _temp = stations;
		_temp.Remove (_station_to_go);

		Transform _spawn = _temp[Random.Range( 0,_temp.Count )].transform;


		transform.position = _spawn.position;

		if (_temp.Contains (_station_to_go)) {
		
			print ("I fucked up");
		
		} else {

			print ("Okay boss");
		}

	}

	public void AddAllStations(){
		WayPoint[] go = WayPoint.FindObjectsOfType<WayPoint> ();    
		foreach(WayPoint station in go)
			AddTarget(station);

	}

	public void AddTarget(WayPoint station){
		stations.Add(station);    

	}
		
}

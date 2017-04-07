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

		GameObject _station_to_go = stations [Random.Range (0, stations.Count)].gameObject;
		canvas.GetComponentInChildren<Text> ().text = "Vous voulez\naller à : " + _station_to_go.GetComponentInChildren<TextMesh> ().text;
		canvas.GetComponentInChildren<Text> ().enabled = false;


		foreach(WayPoint item in stations){

			foreach(Transform child in item.transform)
			{
				child.transform.gameObject.SetActive(false);
			}

		}

		Transform _spawn = stations[Random.Range( 0, stations.Count )].transform;
		transform.position = _spawn.position;



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

using UnityEngine;
using System.Collections;

public class ZoomInOut : MonoBehaviour {
	Manager manager;
    public int id;
	public bool isClicked;

	ZoomInOut [] allPlanetZoom;
	// Use this for initialization
	void Start () {
		allPlanetZoom = GameObject.FindObjectsOfType<ZoomInOut>();

		manager = GameObject.FindObjectOfType<Manager>();
	}
	
	// Update is called once per frame
	void Update () {
		if(isClicked)
			manager.SetCamera(new Vector3(transform.position.x,transform.position.y,Camera.main.transform.position.z));
            
    }
    
	void OnMouseDown(){
		if(!isClicked){
			foreach(ZoomInOut planetZoom in allPlanetZoom){
				planetZoom.isClicked = false;
			}
			isClicked = true;
            if(id == 0)
                manager.planetName.text = "Merkurius";
            else if(id == 1)
                manager.planetName.text = "Venus";
            else if (id == 2)
                manager.planetName.text = "Bumi";
            else if (id == 3)
                manager.planetName.text = "Mars";
            else if (id == 4)
                manager.planetName.text = "Jupiter";
            else if (id == 5)
                manager.planetName.text = "Saturnus";
            else if (id == 6)
                manager.planetName.text = "Uranus";
            else if (id == 7)
                manager.planetName.text = "Neptunus";
        }
        else{
			manager.ReturnCamera();
			isClicked = false;
            manager.planetName.text = "";
        }
	}
}

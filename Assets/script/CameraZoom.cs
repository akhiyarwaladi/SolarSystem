using UnityEngine;
using System.Collections;

public class CameraZoom : MonoBehaviour {
    Camera camera2D;
	// Use this for initialization
	void Start () {
        camera2D = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Equals))
        {
            camera2D.orthographicSize -= 0.1f;
        }
        else if (Input.GetKey(KeyCode.Minus))
        {
            camera2D.orthographicSize += 0.1f;
        }
    }
}

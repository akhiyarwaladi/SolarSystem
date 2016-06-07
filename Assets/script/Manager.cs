using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
public class Manager : MonoBehaviour {
    public GameObject[] planetObjects;
    public GameObject[] moonObjects;
    List<Planet> planets = new List<Planet>();
    List<Moon> moons = new List<Moon>();

    private bool Mulai = false;
    public Text merkuriusCount;
    public Text venusCount;
    public Text bumiCount;
    public Text marsCount;
    public Text jupiterCount;
    public Text saturnusCount;
    public Text uranusCount;
    public Text neptunusCount;
    
    void Start () {
        planets.Add(new Planet());
        planets[0].SetPlanet("Merkurius", 1.533f, new Vector3(0f,0f,0f), new Vector3(0f, 0f, 0f));
        planets.Add(new Planet());
        planets[1].SetPlanet("Venus", 1.1338f, new Vector3(0f, 0f, 0f), new Vector3(0f, 0f, 0f));
        planets.Add(new Planet());
        planets[2].SetPlanet("Bumi", 0.9642f, new Vector3(0f, 0f, 0f), new Vector3(0f, 0f, 0f));
        planets.Add(new Planet());
        planets[3].SetPlanet("Mars", 0.7795f, new Vector3(0f, 0f, 0f), new Vector3(0f, 0f, 0f));
        planets.Add(new Planet());
        planets[4].SetPlanet("Jupiter", 0.4227f, new Vector3(0f, 0f, 0f), new Vector3(0f, 0f, 0f));
        planets.Add(new Planet());
        planets[5].SetPlanet("Saturnus", 0.3121f, new Vector3(0f, 0f, 0f), new Vector3(0f, 0f, 0f));
        planets.Add(new Planet());
        planets[6].SetPlanet("Uranus", 0.2201f, new Vector3(0f, 0f, 0f), new Vector3(0f, 0f, 0f));
        planets.Add(new Planet());
        planets[7].SetPlanet("Neptunus", 0.1760f, new Vector3(0f, 0f, 0f), new Vector3(0f, 0f, 0f));

        moons.Add(new Moon());
        moons[0].SetMoon("Bulan Merkurius", 5f, new Vector3(0f, 0f, 0f));
        moons.Add(new Moon());
        moons[1].SetMoon("Bulan Venus", 5f, new Vector3(0f, 0f, 0f));
        moons.Add(new Moon());
        moons[2].SetMoon("Bulan Bumi", 5f, new Vector3(0f, 0f, 0f));
        moons.Add(new Moon());
        moons[3].SetMoon("Bulan Mars", 5f, new Vector3(0f, 0f, 0f));
        moons.Add(new Moon());
        moons[4].SetMoon("Bulan Jupiter", 5f, new Vector3(0f, 0f, 0f));
        moons.Add(new Moon());
        moons[5].SetMoon("Bulan Saturnus", 5f, new Vector3(0f, 0f, 0f));
        moons.Add(new Moon());
        moons[6].SetMoon("Bulan Uranus", 5f, new Vector3(0f, 0f, 0f));
        moons.Add(new Moon());
        moons[7].SetMoon("Bulan Neptunus", 5f, new Vector3(0f, 0f, 0f));
    }
	
	void Update () {
        if (Mulai)
        {
            for (int i = 0; i < 8; i++)
            {
                planets[i].AddRotation();
                planets[i].GetRotationNow();
                planetObjects[i].transform.eulerAngles = planets[i].GetRotation();             
            }
            for (int i = 0; i < 8; i++)
            {
                moons[i].AddRotation();
                moonObjects[i].transform.eulerAngles = moons[i].GetRotation();
            }
            merkuriusCount.text = "Merkurius \n Orbit " + ((int)((planets[0].GetRotationNow())/359f)).ToString() 
                + "\n Velocity " + planets[0].GetVelocity().ToString() + "\n\n";
            venusCount.text = "Venus \n Orbit " + ((int)((planets[1].GetRotationNow()) / 359f)).ToString()
                + "\n Velocity " + planets[1].GetVelocity().ToString() + "\n\n";
            bumiCount.text = "Bumi \n Orbit " + ((int)((planets[2].GetRotationNow()) / 359f)).ToString()
                + "\n Velocity " + planets[2].GetVelocity().ToString() + "\n\n";
            marsCount.text = "Mars \n Orbit " + ((int)((planets[3].GetRotationNow()) / 359f)).ToString()
                + "\n Velocity " + planets[3].GetVelocity().ToString() + "\n\n";
            jupiterCount.text = "Jupiter \n Orbit " + ((int)((planets[4].GetRotationNow()) / 359f)).ToString()
                + "\n Velocity " + planets[4].GetVelocity().ToString() + "\n\n";
            saturnusCount.text = "Saturnus \n Orbit " + ((int)((planets[5].GetRotationNow()) / 359f)).ToString()
                + "\n Velocity " + planets[5].GetVelocity().ToString() + "\n\n";
            uranusCount.text = "Uranus \n Orbit " + ((int)((planets[6].GetRotationNow()) / 359f)).ToString()
                + "\n Velocity " + planets[6].GetVelocity().ToString() + "\n\n";
            neptunusCount.text = "Neptunus \n Orbit " + ((int)((planets[7].GetRotationNow()) / 359f)).ToString()
                + "\n Velocity " + planets[7].GetVelocity().ToString() + "\n\n"; ; 
        }
    }

    public void mulaiSimulasi()
    {
        Debug.Log("Mulai Simulasi");
        if (!Mulai)
            Mulai = true;
    }
    public void stopSimulasi()
    {
        Debug.Log("Berhenti");
        if (Mulai)
            Mulai = false;
    }
}

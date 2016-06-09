using UnityEngine;
using System.Collections;

public class Planet {
    string name;
    float velocity;
    Vector3 rotation;
    float rotationNow;
    float korX;
    float korY;
    int rotationCount;
    public void SetPlanet(string _name,float _velocity,Vector3 _rotation) {
        name = _name;
        velocity = _velocity;
        rotation = _rotation;
        rotationCount = 0;
        rotationNow = 0;
    }

    public float GetVelocity()
    {
        return velocity;
    }

    public Vector3 GetRotation()
    {
        return rotation;
    }

    public void AddRotation(){
        this.rotation.z += velocity;
        this.rotationNow += velocity;
    }

    public void ResetRotation()
    {
        this.rotation.z = 0;
    }

	public float GetRotationNow()
    {
        return rotationNow;
    }

}


public class Moon
{
    string name;
    float velocity;
    Vector3 rotation;
    public void SetMoon(string _name, float _velocity, Vector3 _rotation)
    {
        name = _name;
        velocity = _velocity;
        rotation = _rotation;
    }

    public Vector3 GetRotation()
    {
        return rotation;
    }

    public void AddRotation()
    {
        rotation.z += velocity;
    }

}
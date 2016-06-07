using UnityEngine;
using System.Collections;

public class Planet {
    string name;
    float velocity;
    Vector3 rotation;
    Vector3 position;
    float rotationNow;
    float korX;
    float korY;
    int rotationCount;
    public void SetPlanet(string _name,float _velocity,Vector3 _rotation,Vector3 _position) {
        name = _name;
        velocity = _velocity;
        rotation = _rotation;
        position = _position;
        rotationCount = 0;
        rotationNow = 0;
    }

    public Vector3 GetRotation()
    {
        return rotation;
    }

    public Vector3 GetPosition()
    {
        return position;
    }

    public float GetVelocity()
    {
        return velocity;
    }

    public void AddRotation(){
        this.rotation.z += velocity;
        this.rotationNow += velocity;
    }

	public float GetRotationNow()
    {
        return rotationNow;
    }

    public float GetKorX()
    {
        return this.position.x;
    }

    public float GetKorY()
    {
        return this.position.y;
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
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.UIElements;

public class VehicleManager : MonoBehaviour
{
    protected Rigidbody body;

    protected string model = "none";
    protected string color = "none";
    protected float speed = 2.0f;
    protected int maxPeople = 0;
    protected bool isFlying = false;
    protected bool isOn = false;

    protected int year_m = 0;

    // ENCAPSULATION
    protected int year
    {
        get
        {
            return year;
        }

        set
        {
            if (value < 0)
            {
                Debug.LogError("Wrong year value!");
            }
            else
            {
                year_m = value;
            }
        }
    }

    protected void displayInfo()
    {
        Debug.Log($"Model: {model},\n Color: {color},\n Max people: {maxPeople},\n Year: {year_m},\n isFlying: {isFlying},\n Speed: {speed},\n\n Is On: {isOn}");
    }

    protected virtual void Move(float vertic)
    {
        body.velocity = new Vector3(transform.position.z * speed * Time.deltaTime * -vertic, 0, 0);
    }

    protected void StopMoving()
    {
        body.velocity = Vector3.zero;
    }

    // ABSTRACTION
    protected bool IfCanMove()
    {
        if((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S)) && isOn)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

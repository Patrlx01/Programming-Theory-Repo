using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;


// INHERITANCE
public class PlaneManager : VehicleManager
{
    private float verticalInput;

    // POLYMORPHISM
    protected override void Move(float vertic)
    {
        body.velocity = new Vector3(0,transform.position.y * speed * Time.deltaTime * vertic, 0);
    }

    void Start()
    {
        model = "Airlane";
        color = "white";
        speed = 1.0f;
        maxPeople = 500;
        isFlying = true;
        year = 2013;
        isOn = true;

        body = GetComponent<Rigidbody>();

        displayInfo();
    }

    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");

        if (IfCanMove())
        {
            Move(verticalInput);
        }
        else
        {
            StopMoving();
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// INHERITANCE
public class CarManager : VehicleManager
{
    private float verticalInput;

    // POLYMORPHISM
    protected override void Move(float vertic)
    {
        body.velocity = new Vector3(0, 0, transform.position.z * speed * Time.deltaTime * vertic);
    }

    void Start()
    {
        model = "Audi";
        color = "black";
        speed = 1.0f;
        maxPeople = 5;
        isFlying = false;
        year = 2003;
        isOn = true;

        body = GetComponent<Rigidbody>();

        displayInfo();
    }

    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");

        if (IfCanMove())
        {
            Move(-verticalInput);
        }
        else
        {
            StopMoving();
        }
    }
}
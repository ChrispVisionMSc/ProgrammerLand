using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sect02 : MonoBehaviour
{
    public string visitorName;
    public string visitorAddress;
    public int phoneNumber;
    public string emailAddress;

    public int ticketQuantity;
    public float ticketPrice;
    public float totalCost;

    public bool seasonTicketHolder;
    public bool concessionary;




    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(visitorName);

        totalCost = ticketPrice * ticketQuantity;

        Debug.Log(totalCost);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

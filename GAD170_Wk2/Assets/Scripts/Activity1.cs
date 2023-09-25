using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activity1 : MonoBehaviour
{
    public string favGame = "Wolfenstein: The New Order";
    public int hoursPlayed = 200;
    public float howMuch = 29.95f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("My favourite game is " + favGame + ". I have played it for " + hoursPlayed + " hours." + " I bought it for $" + howMuch + " My dollar per hour is: " + howMuch / hoursPlayed);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

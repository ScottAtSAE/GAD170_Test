using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activity2 : MonoBehaviour
{
    //Declared random float
    public float randomNumber;
    // Start is called before the first frame update
    void Start()
    {
        //Random number between 1 and 10
        randomNumber = Random.Range(1, 10);
        if (randomNumber == 1)
        {
            Debug.Log("The number was exactly " + randomNumber);
        }
        else if (randomNumber > 7||randomNumber < 5)
        {
            Debug.Log("The number was greater than 7 or less than 5.");
        }
        else if (randomNumber >= 1 && randomNumber <= 5)
        {
            Debug.Log("The number was greater than 1 and less than 5.");
        }
        else if (randomNumber >= 5)
        {
            Debug.Log("The number was greater than 5.");
        }
        else if (randomNumber > 3 && randomNumber < 4)
        {
            Debug.Log("The number was greater than 3.");
        }
        else
        {
            Debug.Log("The number was 6 or 7.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activity3 : MonoBehaviour
{
    public int strength;
    public int agility;
    public int intelligence;
    public int statPool;
    
    // Start is called before the first frame update
    void Start()
    {
        statPool = 20;

        //Strength stat
        strength = Random.Range(0, statPool);
        statPool = statPool - strength;

        //Agility Stat
        agility = Random.Range(0, statPool);
        statPool = statPool - agility;

        //Intelligence Stat
        intelligence = Random.Range(0, statPool);
        statPool = statPool - intelligence;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("My character stats are:");
            Debug.Log("Strength: " + strength);
            Debug.Log("Agility: " + agility);
            Debug.Log("Intelligence: " + intelligence);
        }
    }
}

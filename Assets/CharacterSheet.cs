using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSheet : MonoBehaviour
{

    // Variables visible in Unity
    [SerializeField] string characterName = "Tav";
    [SerializeField] int proficiency = 0;
    [SerializeField] bool usingFinesseWeapon;
    [SerializeField] [Range (-5, 5)] int strengthModifier = 0;
    [SerializeField] [Range (-5, 5)] int dexterityModifier = 0;

    // Start is called before the first frame update
    void Start()
    {
        // Display on console
        Debug.Log("Character Name: " + characterName);
        Debug.Log("Proficiency: " + proficiency);
        Debug.Log("Using a finesse weapon?: " + usingFinesseWeapon);
        Debug.Log("Stength: " + strengthModifier);
        Debug.Log("Dexterity: " + dexterityModifier);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

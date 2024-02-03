using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSheet : MonoBehaviour
{

    // Variables public in Unity
    [SerializeField] string characterName = "Tav";
    [SerializeField] int proficiency = 0;
    [SerializeField] bool usingFinesseWeapon;
    [SerializeField] [Range (-5, 5)] int strengthModifier = 0;
    [SerializeField] [Range (-5, 5)] int dexterityModifier = 0;

    // Variables private
    private int hitModifier = 0;
    private int armorClass = 0;
    private bool isHit = false;

    // Start is called before the first frame update
    void Start()
    {
        // Display on console
        Debug.Log("Character Name: " + characterName);
        Debug.Log("Proficiency: " + proficiency);
        Debug.Log("Using a finesse weapon?: " + usingFinesseWeapon);
        Debug.Log("Stength: " + strengthModifier);
        Debug.Log("Dexterity: " + dexterityModifier);


        // Determine character hit modifier
        if (usingFinesseWeapon)
        {
            // If using finesse and str is higher stat
            if (strengthModifier > dexterityModifier)
            {
                hitModifier = strengthModifier + proficiency;
            }
            // If using finesse and dex is higher stat
            else hitModifier = dexterityModifier + proficiency;
        }
        // If not using finesse default
        else hitModifier = strengthModifier + proficiency;
        
       

        // Determine enemy stats
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

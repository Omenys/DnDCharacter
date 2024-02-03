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
    private int enemyArmorClass = 0;
    private int attackRoll = 0;
    private int diceRoll = 1;

    // Start is called before the first frame update
    void Start()
    {
        // Display on console
        //Debug.Log("Character Name: " + characterName);
        //Debug.Log("Proficiency: " + proficiency);
        //Debug.Log("Using a finesse weapon?: " + usingFinesseWeapon);
        //Debug.Log("Strength: " + strengthModifier);
        //Debug.Log("Dexterity: " + dexterityModifier);


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

        // Display hit modifier
        if (hitModifier > 0)
        {
            Debug.Log(characterName + "'s Hit Modifier: +" + hitModifier);
        }
        else Debug.Log(characterName + "'s Hit Modifier: " + hitModifier);


        // Determine enemy armor class
        enemyArmorClass = Random.Range(10, 21);

        // Display ememy armor class
        Debug.Log("Enemy armor class is " + enemyArmorClass);

        // Roll a D20 (random betweem 1-20)
        diceRoll = Random.Range(1, 21);
        // Display roll
        Debug.Log(characterName + "rolled a " + diceRoll);

        // Add dice roll to hit modifier
        attackRoll = diceRoll + hitModifier;

        // Determine if character hits enemy
        if (attackRoll >= enemyArmorClass)
        {
            Debug.Log(characterName + "successfully landed a hit!");
        }
        else Debug.Log(characterName + "missed!");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

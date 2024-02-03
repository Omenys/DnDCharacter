using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSheet : MonoBehaviour
{

    // Variables visible in Unity
    [SerializeField] string characterName = "Tav";
    [SerializeField] int profBonus = 0;
    [SerializeField] bool usingFinesseWeapon;
    [SerializeField] [Range (-5, 5)] int strengthModifier = 0;
    [SerializeField] [Range (-5, 5)] int dexterityModifier = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

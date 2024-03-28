using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{
   private string name = "Tom";
   private int health = 100;

   public string Name { get {return name;} private set{} }
   
   public int Health 
   {
        get
        {
            return health;
        }
        set 
        {
            if (value < 0 || value > 100)
            {
                Debug.Log("Health value must be from 0 to 100");
            }
            else
            {
                health = value;
            }
        }
   }
}

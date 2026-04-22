using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;




[CreateAssetMenu(fileName = "Aliens", menuName = "ScriptableObjects/AlienData")]
public class  Alien : ScriptableObject
{
   public string npc_name;
   public Sprite npc;

   public string description;

   public bool eyesWrong;

   public bool upperbodywrong;

   public bool lowerbodyWrong;

   

}

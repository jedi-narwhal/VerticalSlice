using System.Collections;
using System.Collections.Generic;
using UnityEngine;




[CreateAssetMenu(fileName = "Aliens", menuName = "ScriptableObjects/AlienData")]
public class alien : ScriptableObject
{
   public string npc_name;
   public Sprite npc;

   public string description;

   public bool is_anamoly;

   public bool is_correct;

}

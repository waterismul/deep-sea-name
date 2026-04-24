using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="Food Data")]
public class FoodData : ScriptableObject
{
    public string itemName;
    public int hungerRestoreAmount;
    public int happinessIncreaseAmount;
    public int price;
}

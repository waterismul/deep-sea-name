using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class ShopItemSlot : MonoBehaviour
{
  [SerializeField] private ItemData itemData;

  [SerializeField] private Text itemText;
  [SerializeField] private Text priceText;
  

  [SerializeField] private ShopPurchaseController shopPurchaseController;
  

  public int CurrentCount { private set; get; }
  
  private void Start()
  {
    itemText.text = itemData.itemName;
    priceText.text = itemData.price.ToString();
  }

  public void ClickItemSlot()
  {
    shopPurchaseController.OnPurchased = () =>
    {
      return itemData;
    };
  }

  public void AddCount()
  {
    CurrentCount++;
  }
  
  

  
}

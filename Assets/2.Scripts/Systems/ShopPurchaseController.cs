using System;
using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class ShopPurchaseController : MonoBehaviour
{
    [SerializeField] private GameObject checkbox; //구매확인 창
    [SerializeField] private GameObject buyMassagebox; //구매완료 창
    [SerializeField] private CoinSystem coinSystem;

    [SerializeField] private GameObject itemSlot;
    [SerializeField] private Transform itemSlotContentTransform;
    [SerializeField] private Text itemText;
    [SerializeField] private Text priceText;
    
    public Func<ItemData> OnPurchased;
    
    public Dictionary<string, GameObject> items = new();
    public Dictionary<string, int> itemCounts = new();

    public void ClickItemSlotUI()
    {
        checkbox.SetActive(true);
    }
    
    public void ToBuy()
    {
        
        var data = OnPurchased();
        int price = data.price;
        string itemName = data.itemName;
        int count = 0;
        
        if (items.ContainsKey(itemName)) //이미 아이템을 산적이 있다면,
        {
            itemCounts[itemName]++;
            Text[] haveTexts= items[itemName].GetComponentsInChildren<Text>();
            haveTexts[1].text = itemCounts[itemName].ToString();
        }
        else //새로운 아이템을 구매했다면,
        {
            GameObject initSlot = Instantiate(itemSlot, itemSlotContentTransform);
            items.Add(itemName, initSlot);
            itemCounts.Add(itemName, 1);
            
            Text[] texts = initSlot.GetComponentsInChildren<Text>();
            texts[0].text = itemName;
            texts[1].text = itemCounts[itemName].ToString();
            
        }
        
        coinSystem.ChargeCoin(price);
        
        ToCancel();
        
        buyMassagebox.SetActive(true);
        DOVirtual.DelayedCall(1f, () =>
        {
            buyMassagebox.SetActive(false);
        });
        
    }
    
    public void ToCancel()
    {
        checkbox.SetActive(false);
    }
    
    
}

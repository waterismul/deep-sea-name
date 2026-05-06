using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ShopPurchaseController : MonoBehaviour
{
    [SerializeField] private GameObject checkbox; //구매확인 창
    [SerializeField] private GameObject buyMassagebox; //구매완료 창
    [SerializeField] private CoinSystem coinSystem;


    public Func<ItemData> OnPurchased;

    public void ClickItemSlotUI()
    {
        checkbox.SetActive(true);
    }
    
    public void ToBuy()
    {
        
        int price = OnPurchased().price;
        coinSystem.AddCoin(-price);
        
        
        Debug.Log($"지갑에는... {coinSystem.CurrentCoin} 원 있습니다.");
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

using System;
using UnityEngine;

public class CoinSystem : MonoBehaviour
{
    public int CurrentCoin { get; private set; }
    public event Action<int> OnCoinChanged;
    public Action<int> OnCoinUIChanged;

    public void AddCoin(int amount)
    {
        //if (amount <= 0) return;
        
        CurrentCoin += amount;
        OnCoinChanged?.Invoke(CurrentCoin);
        OnCoinUIChanged?.Invoke(CurrentCoin);
        Debug.Log($"현재 소지액: {CurrentCoin}");
    }

    public bool SpendCoin(int amount)
    {
        if (amount <= 0) return false;
        if (CurrentCoin < amount) return false;
        
        CurrentCoin -= amount;
        OnCoinChanged?.Invoke(CurrentCoin);
        return true;
    }
    
    public void SetCoin(int amount)
    {
        CurrentCoin = Mathf.Max(0, amount); //음수 방지
        OnCoinChanged?.Invoke(CurrentCoin);
    }

   

    
}

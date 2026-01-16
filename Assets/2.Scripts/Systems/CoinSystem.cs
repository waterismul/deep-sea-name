using System;
using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class CoinSystem : MonoBehaviour
{
    public int CurrentCoin { get; private set; }
    public event Action<int> OnCoinChanged;

    public void AddCoin(int amount)
    {
        if (amount <= 0) return;
        
        CurrentCoin += amount;
        OnCoinChanged?.Invoke(CurrentCoin);
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

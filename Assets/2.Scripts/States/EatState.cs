using UnityEngine;

public class EatState : IState
{
    public void Enter()
    {
        Debug.Log("먹기 시작!");
    }

    public void Update()
    {
        Debug.Log("먹는 중~");
    }

    public void Exit()
    {
        Debug.Log("먹기 끝.");
    }
}

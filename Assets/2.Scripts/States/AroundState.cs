using UnityEngine;

public class AroundState : IState
{
    public void Enter()
    {
        Debug.Log("떠돌기 시작!");
    }

    public void Update()
    {
        Debug.Log("떠도는 중~");
    }

    public void Exit()
    {
        Debug.Log("떠돌기 끝.");
    }
}

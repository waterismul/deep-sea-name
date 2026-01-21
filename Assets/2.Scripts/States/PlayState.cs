using UnityEngine;

public class PlayState: IState
{
    public void Enter()
    {
        Debug.Log("게임 시작!");
    }

    public void Update()
    {
       Debug.Log("게임 중~");
    }

    public void Exit()
    {
        Debug.Log("게임 끝.");
    }
}

using UnityEngine;

public interface IState
{
    void Enter(); // 상태 시작
    void Update(); // 상태 진행중
    void Exit(); // 상태 끝
    
}

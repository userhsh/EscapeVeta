using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassroomDoor : Door
{
    private void Awake()
    {
        ClassroomDoorInit();
    }

    // 시체 안치실 문 init 메서드
    private void ClassroomDoorInit()
    {
        // 현재 로드된 씬 이름 가져오기
        GetCurrentSceneName();

        PlayerPositionInit();

        // 문을 열린 상태로 
        isLocked = false;

        // 이동할 씬 이름 가져오기
        if (currentSceneName == SCENENAME.HallwayScene.ToString()) // 현재 씬이 복도 씬이라면 
        {
            // 이동할 씬 이름에 교실 씬 이름 가져오기
            moveSceneName = SCENENAME.ClassroomScene.ToString();
        }
        else // 현재 씬이 복도 씬이 아니라면
        {
            // 이동할 씬 이름에 복도 씬 이름 가져오기
            moveSceneName = SCENENAME.HallwayScene.ToString();
        }
    }
}
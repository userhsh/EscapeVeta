using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassroomKey : Key
{
    private void Awake()
    {
        ClassroomKeyInit();
    }

    // ClassroomKey Init �޼���
    private void ClassroomKeyInit()
    {
        // ���� Ű�� ClassroomKey�� ����
        currentKey = KEY.ClassroomKey;
    }
}
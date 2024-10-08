using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class LeftController : MonoBehaviour
{
    public InputActionReference menu; //�޴� UI �Ѵ� Ű
    public InputActionReference collectionOn; //����ǰ UI �Ѵ� Ű
    public InputActionReference collectionOff; //����ǰ UI ���� Ű
    public GameObject UImenu; //�޴� UI ������Ʈ
    public GameObject UIcollection; //����ǰ UI ������Ʈ

    public GameObject LeftHandRender; //���� �� ������

    private void Start()
    {
        menu.action.performed += MenuOn;
        collectionOn.action.performed += CollectionOn;
        collectionOff.action.performed += CollectionOff;
    }

    void MenuOn(InputAction.CallbackContext context) //�޴� Ű ���� ��
    {
         UImenu.SetActive(true);
    }

    void CollectionOn(InputAction.CallbackContext context) //YŰ ���� ��
    {
        UIcollection.SetActive(true);
        print("uiŴ");
    }
    void CollectionOff(InputAction.CallbackContext context) //XŰ ���� ��
    {
        UIcollection.SetActive(false);
        print("ui��");
    }

    public void LeftHandRenderIdle() //������ �޼շ����� ����
    {
        LeftHandRender.SetActive(true);
    }

    public void LeftHandRenderGripping() //������ ��ȣ�ۿ�� �޼շ����� ����
    {
        LeftHandRender.SetActive(false);
    }


}

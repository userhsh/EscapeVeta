using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Remocon : MonoBehaviour, IUseable
{
    IInteractable interactable = null;

    TV TV = null;
    Player player = null;

    private void Awake()
    {

    }

    private void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        

        TV = other.gameObject.GetComponent<TV>();
        player = other.gameObject.GetComponent<Player>();
        interactable = other.gameObject.GetComponent<IInteractable>();

        if(player != null ) 
        {
            
        }
        else if (TV != null)
        {
            interactable?.Interact();
        }
        else
        {
            print("�ٸ� ���� ����غ���.");
        }
    }


    public void GetItem(Transform _pos)
    {
        print("������ ȹ��");
        this.gameObject.SetActive(false);
    }


    public void Use(Collider _collider)
    {

    }
}

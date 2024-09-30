using UnityEngine;

public interface IUseable
{
    // ������ ȹ�� (Transform ������ ���ڷ� �޾Ƽ� ���)
    public void GetItem(Transform _pos);
    // ������ ��� (Collider ������ ���ڷ� �޾Ƽ� ���)
    public void Use(Collider _collider);
}
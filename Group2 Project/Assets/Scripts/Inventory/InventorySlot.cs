using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public Item item;//��ϵ� ������ ����
    public Image itemImage;//������ �̹��� ��ϵ� �ڸ�
    public int itemCount;//�ش� ������ ���� ����

    public void UpdateSlotUI() {
        itemImage.sprite = item.itemImage;
        itemImage.gameObject.SetActive(true);
    }
    public void RemoveSlot() {
        item = null;
        itemImage.gameObject.SetActive(false);
    }
}

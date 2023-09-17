using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour
{
    [SerializeField] private ItemData _itemData;

    private void Awake()
    {
        if (_itemData == null) return;

        var spawnedSprite = Instantiate<Image>(_itemData.Sprite, transform.position, Quaternion.identity, transform);
    }
}

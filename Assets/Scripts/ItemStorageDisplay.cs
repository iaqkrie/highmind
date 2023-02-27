using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemStorageDisplay : MonoBehaviour {
	public const int SLOT_SIZE = 38;

	public int xPadding;
	public int yPadding;
	public int nSlotInRow;

	public ItemStorage storage;

	private GameObject _itemSlotPrefab;

	private void Awake () {
		storage = new ItemStorage(10);
	}

	private void Start () {
		_itemSlotPrefab = Resources.Load<GameObject>("Prefab/ItemSlotPrefab");

		for (int i = 0; i < storage.capacity; i++) {
			GameObject slot = Instantiate(_itemSlotPrefab, transform);
			RectTransform rt = slot.GetComponent<RectTransform>();

			int nRow = 1;
			float xPos = xPadding + SLOT_SIZE / 2 + i * SLOT_SIZE;
			float yPos = yPadding + SLOT_SIZE / 2;
			if (nSlotInRow + 1 == (i + 1) * nRow)
				yPos += SLOT_SIZE; // TODO

			rt.anchorMin = new Vector2(0f, 1f);
			rt.anchorMax = new Vector2(0f, 1f);
			rt.sizeDelta = new Vector2(38f, 38f);
			rt.anchoredPosition = new Vector2(xPos, -yPos);
		}
	}
}

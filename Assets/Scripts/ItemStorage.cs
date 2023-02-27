using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Slot : byte {
	SINGLE,
	LOCKED,
	UDR,
	UDL,
	URL,
	DRL,
	UR,
	UL,
	DR,
	DL,
	U,
	D,
	R,
	L,
	O
}

public class ItemStorage {
	public int capacity;

	private Slot[] _slots;
	private Dictionary<ItemBase, ItemLocation> _items;

	private int _emptySlots;

	public ItemStorage(int capacity) {
		this.capacity = capacity;

		_slots = new Slot[this.capacity];
		_items = new Dictionary<ItemBase, ItemLocation>();

		_emptySlots = this.capacity;
	}

	public void Put(ItemBase item, int ulSlot) {
		_emptySlots -= item.hSize * item.vSize;
		_items.Add(item, new ItemLocation(item, ulSlot));
	}
}

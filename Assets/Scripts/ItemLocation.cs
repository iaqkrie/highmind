using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemLocation {
	public int ulSlot;

	private int _hSize;
	private int _vSize;
	private bool _rotated;

	public ItemLocation(ItemBase item, int ulSlot) {
		this.ulSlot = ulSlot;

		_hSize = item.hSize;
		_vSize = item.vSize;
		_rotated = false;
	}
}

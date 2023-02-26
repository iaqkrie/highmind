using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemBase {
	public string name;
	public string displayName;
	public ItemSize size;

	public Sprite sprite;

	public abstract void LoadResources ();
}

public enum ItemSize {
	SLOT,
	S1X2,
	S1X3,
	S1X4,
	S1X5,
	S1X6,
	S2X2,
	S2X3,
	S2X4,
	S2X5,
	S2X6,
	S3X3,
	S3X4,
	S3X5,
	S3X6,
	S4X4,
	S4X5,
	S4X6,
	S5X5,
	S5X6,
	S6X6
}

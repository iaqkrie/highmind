using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemBase {
	public string name;
	public string displayName;
	public int hSize;
	public int vSize;

	public Sprite sprite;

	public abstract void LoadResources ();
}

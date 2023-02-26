using UnityEngine;

public abstract class Item : ItemBase {
	public override void LoadResources () {
		sprite = Resources.Load<Sprite>($"Sprite/item/{name}");
	}
}

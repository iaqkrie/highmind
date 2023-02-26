using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class I_stick : Item {
	public I_stick() {
		name = "stick";
		displayName = "Stick";
		size = ItemSize.SLOT;

		LoadResources();
	}
}

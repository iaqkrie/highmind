using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class I_test : Item {
	public I_test() {
		name = "test";
		displayName= "Test";
		size = ItemSize.S2X2;

		LoadResources();
	}
}

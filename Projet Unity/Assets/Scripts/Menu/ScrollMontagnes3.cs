﻿using UnityEngine;
using System.Collections;

public class ScrollMontagnes3 : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		MeshRenderer mr = GetComponent<MeshRenderer>();
		Material mat = mr.material;
		Vector2 offset = mat.mainTextureOffset;
		offset.x += Time.deltaTime/100 ;
		mat.mainTextureOffset = offset;
	}
}

using UnityEngine;
using System.Collections;

public class DrawPile : MonoBehaviour {
	private TextMesh texto;
	// Use this for initialization
	void Start () {
		texto = gameObject.GetComponentInChildren<TextMesh> ();
	}
	
	// Update is called once per frame
	void Update () {
		texto.text = (GameManager.DrawPile.ToString());
	}
}

using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	public GameObject cardprefab;
	//public static GameObject[] cartaobj = new GameObject[17];
	public static GameObject cartaobj;
	 public static PolicyCards[] carta = new PolicyCards[17];

	public static int DrawPile = 17;
	public static int DiscardPile = 0;

	Vector3 pos;
	Quaternion rot;
	float time;

	private int i = 0;


	// Use this for initialization
	void Start () {
		InPolicyCards ();
		GameManagerBase.Embaralhar ();
		TestarEmbaralhamento ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void InPolicyCards () {
		rot = new Quaternion (0, 0, 0, 0);
		while (i < 17) {
			cartaobj = Instantiate(cardprefab, GameManagerBase.DrawPos(), rot) as GameObject;
			carta [i] = cartaobj.GetComponent<PolicyCards> ();
			if (i < 11) {
				carta [i].facistface();
			}
			i++;
		}
		i = 0;
	}


	void TestarEmbaralhamento(){
		while (i < 17) {
			pos = new Vector3 ( 0.3f, 3-(i*0.5f), -0.01f*i);
			GameManagerBase.MoverCarta (carta [i], pos); 
			GameManagerBase.VirarCarta (carta [i]);
			i++;

		}
		i = 0;
	}


}

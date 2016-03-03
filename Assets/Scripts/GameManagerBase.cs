using UnityEngine;
using System.Collections;

public class GameManagerBase : MonoBehaviour {
	private static Transform mover;
	private static PolicyCards temp;
	private static int rand;
	public GameObject DrawPObj;
	public GameObject DiscardPObj;
	private static Transform drawT;
	private static Transform discardT;
	private static Vector3 vetor3;
	private static int i = 0;


	// Use this for initialization
	void Start () {
		drawT = DrawPObj.GetComponent<Transform> ();
		discardT = DiscardPObj.GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {

	}
	public static Vector3 DrawPos(){
		vetor3 = new Vector3 (drawT.position.x, drawT.position.y + 0.12f, -0.01f);
		return vetor3;
	}

	public static Vector3 DiscardPos(){
		vetor3 = new Vector3 (discardT.position.x, discardT.position.y + 0.12f, -0.01f);
		return vetor3;
	}

	public static void Embaralhar (){
		while (i < GameManager.DrawPile) {
			rand = Random.Range (0, 17);
			temp = GameManager.carta [i];
			GameManager.carta [i] = GameManager.carta [rand];
			GameManager.carta [rand] = temp;
			i++;
		}
		i = 0;
	}
	public static void MoverCarta(PolicyCards carta, Vector3 pos){
		//mover = carta.gameObject.GetComponent<Transform>();
		carta.Mover(pos);
		}
	public static void VirarCarta(PolicyCards carta){
		carta.Virar ();
		//mover = carta.gameObject.GetComponent<Transform>();
		//mover.Rotate (0f, 180f, 0f);
	}
	
}

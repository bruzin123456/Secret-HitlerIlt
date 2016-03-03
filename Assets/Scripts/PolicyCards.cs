using UnityEngine;
using System.Collections;
//face.SetBool ("Liberal", false);
public class PolicyCards : MonoBehaviour {
	private bool CardTypeLiberal = true;
	private bool DiscardPyle = false;
	private bool Enacted = false;
	private bool Moving = false;
	private bool rodando = false;
	private Animator face;
	private Vector3 target;
	private Vector3 rodart;
	private Transform mover;

	// Use this for initialization


	void Awake () {
		face = gameObject.GetComponentInChildren<Animator> ();
		mover = gameObject.GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Moving == true) {
			mover.position = Vector3.MoveTowards (mover.position, target, 8f * Time.fixedDeltaTime);
			if (mover.position == target) {
				Moving = false;
			}
		}
		if (rodando == true){
			
		
		}
	}

	public void facistface ()
	{
		CardTypeLiberal = false;
		face.SetBool ("Liberal", false);
	}
	public void Mover (Vector3 Alvo){
		target = Alvo;
		Moving = true;

	}
	public void Virar (){
		rodart = new Vector3 (0, mover.rotation.y + 180f, 0f);
		mover.Rotate (new Vector3 (0, 180f, 0));

		//rodando = true;
	}
		
}

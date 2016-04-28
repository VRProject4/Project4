﻿using UnityEngine;
using System.Collections;

public class Events : MonoBehaviour {

	public GameObject cake;
	public GameObject car;
	public GameObject snack;
	public GameObject makesnack;
	public GameObject book;

	public GameObject kid;
	public GameObject obeseTeen;
	public GameObject athleticTeen;
	public GameObject middleTeen;

	private Transform cakeTrans;
	private Transform carTrans;
	private Transform snackTrans;
	private Transform makesnackTrans;
	private Transform bookTrans;

	private Transform kidTrans;
	private Transform obeseTeenTrans;
	private Transform athleticTeenTrans;
	private Transform middleTeenTrans;

	public bool givenCake;
	public bool givenCar;
	public bool kidExited;
	public bool inKitchen;

	public bool givenBook;
	public bool givenSnack;




	// Use this for initialization
	void Start () {

		givenCake = false;

		kidTrans = kid.GetComponent<Transform> ();
		cakeTrans = cake.GetComponent<Transform> ();
		carTrans = car.GetComponent<Transform> ();

		obeseTeenTrans = obeseTeen.GetComponent<Transform> ();
		athleticTeenTrans = athleticTeen.GetComponent<Transform> ();
		middleTeenTrans = middleTeen.GetComponent<Transform> ();

		snackTrans = snack.GetComponent<Transform> ();
		makesnackTrans = makesnack.GetComponent<Transform> ();
		bookTrans = book.GetComponent<Transform> ();

	}

	// Update is called once per frame
	void Update () {
		//float dist = Vector3.Distance (kidTrans.position, cakeTrans.position);

		//Debug.Log (dist.ToString ());
		Vector3 cakelos = kidTrans.position - cakeTrans.position;
		cakelos = new Vector3 (cakelos.x, 0.0f, cakelos.z);

		if (cakelos.magnitude < 0.4f){
			if (givenCake == false) {
				cake.SetActive (false);

				car.SetActive (false);

				kid.GetComponent<EntryAnimation> ().enabled = !kid.GetComponent<EntryAnimation> ().enabled;
				kid.GetComponent<KitchenAnimation> ().enabled = !kid.GetComponent<KitchenAnimation> ().enabled;

				givenCake = true;

				snack.SetActive (true);
				book.SetActive (true);
			}
		}

		Vector3 carlos = kidTrans.position - carTrans.position;
		carlos = new Vector3 (carlos.x, 0.0f, carlos.z);

		if (carlos.magnitude < 0.4f){
			if (givenCar == false) {
				car.SetActive (false);

				cake.SetActive (false);

				kid.GetComponent<EntryAnimation> ().enabled = !kid.GetComponent<EntryAnimation> ().enabled;
				kid.GetComponent<KitchenAnimation> ().enabled = !kid.GetComponent<KitchenAnimation> ().enabled;

				givenCar = true;

				snack.SetActive (true);
				book.SetActive (true);
			}
		}

		//snack
		Vector3 snacklos = kidTrans.position - snackTrans.position;
		snacklos = new Vector3 (snacklos.x, 0.0f, snacklos.z);

		if (snacklos.magnitude < 0.4f){
			if (givenSnack == false) {
				snack.SetActive (false);

				book.SetActive (false);


				kid.GetComponent<KitchenAnimation> ().enabled = !kid.GetComponent<KitchenAnimation> ().enabled;
				kid.GetComponent<ExitAnimation> ().enabled = !kid.GetComponent<ExitAnimation> ().enabled;

				givenSnack = true;

			}
		}

		Vector3 obeseSnacklos = obeseTeenTrans.position - snackTrans.position;
		obeseSnacklos = new Vector3 (obeseSnacklos.x, 0.0f, obeseSnacklos.z);

		if (obeseSnacklos.magnitude < 0.4f){
			snack.SetActive (false);
		}

		Vector3 athSnacklos = athleticTeenTrans.position - snackTrans.position;
		athSnacklos = new Vector3 (athSnacklos.x, 0.0f, athSnacklos.z);

		if (athSnacklos.magnitude < 0.4f){
			snack.SetActive (false);
		}

		Vector3 midSnacklos = middleTeenTrans.position - snackTrans.position;
		midSnacklos = new Vector3 (midSnacklos.x, 0.0f, midSnacklos.z);

		if (midSnacklos.magnitude < 0.4f){
			snack.SetActive (false);
		}

		//book
		Vector3 booklos = kidTrans.position - bookTrans.position;
		booklos = new Vector3 (booklos.x, 0.0f, booklos.z);

		if (booklos.magnitude < 0.4f){
			if (givenBook == false) {
				book.SetActive (false);

				snack.SetActive (false);

				kid.GetComponent<KitchenAnimation> ().enabled = !kid.GetComponent<KitchenAnimation> ().enabled;
				kid.GetComponent<ExitAnimation> ().enabled = !kid.GetComponent<ExitAnimation> ().enabled;

				givenBook = true;

			}
		}

		Vector3 obeseBooklos = obeseTeenTrans.position - bookTrans.position;
		obeseBooklos = new Vector3 (obeseBooklos.x, 0.0f, obeseBooklos.z);

		if (obeseBooklos.magnitude < 0.4f){
			book.SetActive (false);
		}

		Vector3 athBooklos = athleticTeenTrans.position - bookTrans.position;
		athBooklos = new Vector3 (athBooklos.x, 0.0f, athBooklos.z);

		if (athBooklos.magnitude < 0.4f){
			book.SetActive (false);
		}

		Vector3 midBooklos = middleTeenTrans.position - bookTrans.position;
		midBooklos = new Vector3 (midBooklos.x, 0.0f, midBooklos.z);

		if (midBooklos.magnitude < 0.4f){
			book.SetActive (false);
		}

		//grown kid entry

		if (givenCake && givenSnack && kid.GetComponent<BaseAnimation> ().isAnimated == false) {
			obeseTeen.SetActive (true);
			obeseTeen.GetComponent<EntryAnimation> ().enabled = !obeseTeen.GetComponent<EntryAnimation>().enabled;
		}

		if (givenCake && givenBook && kid.GetComponent<BaseAnimation> ().isAnimated == false) {
			middleTeen.SetActive (true);
			middleTeen.GetComponent<EntryAnimation> ().enabled = !middleTeen.GetComponent<EntryAnimation>().enabled;
		}

		if (givenCar && givenBook && kid.GetComponent<BaseAnimation> ().isAnimated == false) {
			athleticTeen.SetActive (true);
			athleticTeen.GetComponent<EntryAnimation> ().enabled = !athleticTeen.GetComponent<EntryAnimation>().enabled;
		}

		if (givenCar && givenSnack && kid.GetComponent<BaseAnimation> ().isAnimated == false) {
			middleTeen.SetActive (true);
			middleTeen.GetComponent<EntryAnimation> ().enabled = !middleTeen.GetComponent<EntryAnimation>().enabled;
		}



	}
}

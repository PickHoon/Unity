using UnityEngine;
using System.Collections;

public class inputHandler : MonoBehaviour {

	private RaycastHit hits;
	public GameObject one;
	public GameObject onetwo;
	public GameObject two;
	public GameObject twotwo;
	public GameObject twothree;
	public GameObject twofour;
	public GameObject twofive;
	public GameObject twosix;
	public GameObject twoseven;
	public GameObject three;

	GameObject tag1;
	GameObject tag2;

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

			if (Physics.Raycast (ray, out hits)) {

				GameObject mark = hits.collider.gameObject;
				if (mark.name == "e1") {
					Destroy (mark);
					Instantiate (one, one.transform.position, one.transform.rotation);
					Instantiate (onetwo, onetwo.transform.position, onetwo.transform.rotation);
				}
				if (mark.name == "egg1(Clone)" || mark.name=="egg12(Clone)") {
					tag1 = GameObject.FindGameObjectWithTag ("egg");
					Destroy (tag1);
					Instantiate (two, two.transform.position, two.transform.rotation);
					Instantiate (twotwo, twotwo.transform.position, twotwo.transform.rotation);
					Instantiate (twothree, twothree.transform.position, twothree.transform.rotation);
					Instantiate (twofour, twofour.transform.position, twofour.transform.rotation);
					Instantiate (twofive, twofive.transform.position, twofive.transform.rotation);
					Instantiate (twosix, twosix.transform.position, twosix.transform.rotation);
					Instantiate (twoseven, twoseven.transform.position, twoseven.transform.rotation);

				}
				if (mark.name == "egg12(Clone)" || mark.name=="egg2(Clone)"|| mark.name=="egg22(Clone)"|| mark.name=="egg23(Clone)"|| mark.name=="egg24(Clone)"|| mark.name=="egg25(Clone)"|| mark.name=="egg26(Clone)"|| mark.name=="egg27(Clone)") {
					tag1 = GameObject.FindGameObjectWithTag ("egg2");
					Destroy (tag2);
					Instantiate (three, three.transform.position, three.transform.rotation);
					}
			}

		}
	}

}
//www.youtube.com/watch?v=scm7r0uBepU [Unity 3d tutorial]Triggering a door animation from mouse click select


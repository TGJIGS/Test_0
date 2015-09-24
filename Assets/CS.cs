using UnityEngine;
using System.Collections;

public class CS : MonoBehaviour {
    public GameObject circle = null;
    float size_circle = 1f;
    public float speedtobig = 3;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        circle.transform.localScale = new Vector3 (size_circle, size_circle, 1);
        size_circle += Time.deltaTime*speedtobig;
        if (size_circle < 1)
        {
            size_circle = 1;
        }

        if(size_circle > 25)
        {
            size_circle = 25;
        }
	}
    void OnMouseDown()
    {
        circle.gameObject.SetActive(false);

    }
}

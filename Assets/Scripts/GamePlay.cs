using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GamePlay : MonoBehaviour {
    public Text debugprint;
    public Image Avatar;
    public Image Bullet;
    Vector3 newPos = new Vector3(177,63,0);
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Shoot();

	}
    public void Dragging()
    {
        debugprint.text = "dragging" + Input.mousePosition.x + "," + Input.mousePosition.y;
        newPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1.0f);

        Avatar.rectTransform.position = newPos;
        
    }
    public void Shoot()
    {
        Bullet.transform.Translate(0, 15, 0);
        if(Bullet.rectTransform.position.y >600)
        {
            Bullet.rectTransform.position = newPos + new Vector3(5,50,0);
        }
    }
   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class BallControll : MonoBehaviour
{
    Rigidbody fizik;
    public int speed = 10;
    int counter = 0;
    public int toplanilacakObjeSayisi;
    public Text counterText;
    public Text finaleText;
    // Start is called before the first frame update
    void Start()
    {
      fizik = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float yatay = Input.GetAxisRaw("Horizontal");
        float dikey = Input.GetAxisRaw("Vertical");
        bool shift = Input.GetKeyDown(KeyCode.LeftShift);
        Vector3 vec = new Vector3(yatay, 0, dikey);
        fizik.AddForce(vec * speed);
        

        
       // Debug.Log(yatay + "yatay" + dikey + "dikey");

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Engel") ;
        {
            other.gameObject.SetActive(false);
            counter++;
            counterText.text = "Points = " + counter;

            if (counter == toplanilacakObjeSayisi)
            {
                finaleText.text = "YOU WIN !";
            }
            
        }
    }
}

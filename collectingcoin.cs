using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collectingcoin : MonoBehaviour
{
    public Text scoretext;
    
    public int coin=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "coins")
        {
            coin++;
            col.gameObject.SetActive(false);
            //Debug.Log(coins);
        }
        if(col.gameObject.tag=="enemy")
        {
            col.gameObject.SetActive(true);
        }
    }
    // Update is called once per frame
    void Update()
    {
        scoretext.text = coin.ToString();
    }
}

 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnscript : MonoBehaviour
{
   SpriteRenderer sr;  
  public Sprite[] images;
  GameObject gs;

private void Start(){
    sr.sprite = null;
}

  private void OnMouseDown(){
      int index = gs.GetComponent<gamescript>().PlayerTurn();
      sr.sprite = images[index];
  }

  private void Awake(){
      sr = GetComponent<SpriteRenderer>();
      gs = GameObject.Find("Board");

  }
}

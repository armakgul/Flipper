using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UrlNav : MonoBehaviour
{
   public GameObject FacebookCanvas;

   public GameObject InstaCanvas;

   void Start () {

    CloseCanvas();

   }


   public void OpenFacebookCanvas () {
    FacebookCanvas.SetActive(true);
   }

   public void OpenInstaCanvas () {
    InstaCanvas.SetActive(true);
   }

   public void CloseCanvas() {
    FacebookCanvas.SetActive(false);
    InstaCanvas.SetActive(false);
   }

   public void GoToInstaPage(string link) {
        Application.OpenURL(link);
   }

   public void GotoFacebookPage(string link) {
        Application.OpenURL(link);
   }
}

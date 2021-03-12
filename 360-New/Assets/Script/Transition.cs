using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transition : MonoBehaviour
{
       public float maxFOV;
       public float zoomRate;
       public float currentFOV;
       void Start(){
           currentFOV = GetComponent<Camera>().fieldOfView;
       }

            IEnumerator zoomtime(){
            yield return new WaitForSeconds(0.05f);
            if (currentFOV<=maxFOV)
            {
                currentFOV += zoomRate;
            }
            
        }

       public void ZoomInTransition()
       {
           StartCoroutine("ZoomTime");
       }
           //ddd= GetComponent<Camera>();

        


       
}

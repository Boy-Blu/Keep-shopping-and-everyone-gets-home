using UnityEngine;

public class GrabAndMove : MonoBehaviour
{
    GameObject grabbedObject;
    float grabbedObjectSize; 


    GameObject GetMouseHoverObject(float range)
    {
        Vector3 position = gameObject.transform.position;
        RaycastHit raycastHit;
        Vector3 target = position + Camera.main.transform.forward * range;

        if (Physics.Linecast(position, target, out raycastHit))
        {
            return raycastHit.collider.gameObject;
        }
        else
        {
            return null; 
        }
    }

    void TryGrabObject(GameObject grabObject)
    {
        if (grabObject == null)
        {
            return; 
        }

        grabbedObject = grabObject;
        grabbedObjectSize = grabObject.GetComponent<Renderer>().bounds.size.magnitude; 
    }

    void DropObject()
    {
        if (grabbedObject == null)
        {
            return;
        }
        grabbedObject = null; 
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        { 
            if (grabbedObject == null)
            {
                TryGrabObject(GetMouseHoverObject(10));
            }
            else
            {
                DropObject(); 
            }            
        }

        //Debug.Log(grabbedObject.tag); 

        if (grabbedObject != null && grabbedObject.tag == "Fruit" || grabbedObject != null && grabbedObject.tag == "SFruit")
        {
            //Debug.Log("Fruit clicked!");
            Vector3 newPosition = gameObject.transform.position + Camera.main.transform.forward * grabbedObjectSize;
            grabbedObject.transform.position = newPosition; 
        }
    }
}

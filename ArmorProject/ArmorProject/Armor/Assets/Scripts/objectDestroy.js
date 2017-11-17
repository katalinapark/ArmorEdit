#pragma strict


function OnTriggerEnter(other: Collider) 
{
    if (other.tag == "Player")
    {
        Debug.Log("hit");
     
        Destroy(gameObject); 
    }

    else if (other.tag == "Untagged")
        {
        Debug.Log("no!"); 
    }

   
}

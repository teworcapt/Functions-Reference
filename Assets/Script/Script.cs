using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    public List<Color> color;    
    public MeshRenderer meshRenderer;
    public float delayTime;

    // Start is called before the first frame update
    void Start()
    {
        //meshRenderer = GetComponent<MeshRenderer>();
        //for (int i = 0; i < color.Count; i++)
        //{
        //    meshRenderer.material.color = color[Random.Range(0,color.Count)];
        //}
       
    }

    private void OnEnable()
    {
 
    }

    private void OnDisable()
    {

    }

    private void OnMouseDown()
    {
        ChangeColor();
        //Invoke("ChangeColor", delayTime);
    }

    private void OnMouseEnter()
    {

    }

    private void OnMouseExit()
    {

    }

    private void OnMouseOver()
    {
 
    }

    private void OnMouseDrag()
    {

    }

    private void OnMouseUpAsButton()
    {

    }

    public void ChangeColor()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        for (int i = 0; i < color.Count; i++)
        {
            meshRenderer.material.color = color[Random.Range(0, color.Count)];
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
                
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCut : MonoBehaviour
{
    private GameObject _cube;

    // Start is called before the first frame update
    void Start()
    {
        _cube = GameObject.Find("Cube");

        Debug.Log(_cube.name + " found!");

        Mesh mesh = _cube.GetComponent<MeshFilter>().mesh;
        Vector3[] vertices = mesh.vertices;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

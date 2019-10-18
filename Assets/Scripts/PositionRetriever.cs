using UnityEngine;

public class PositionRetriever : MonoBehaviour
{
    public Transform[] markers;

    private Vector2[] positions;

    private void Awake()
    {
        this.CreateArray();
    }

    private void Serve()
    {
        if (this.markers.Length != this.positions.Length)
            this.CreateArray();

        for (int i = 0; i < this.markers.Length; i++)
            this.positions[i].Set(this.markers[i].position.z, this.markers[i].position.x);

        this.Send();
    }

    public void CreateArray()
    {
        this.positions = new Vector2[this.markers.Length];
    }

    //TODO
    public void Send()
    {
        foreach (Vector2 v in this.positions)
            Debug.Log(v);
    }
}

using UnityEngine;

public class Interactable : MonoBehaviour

    //TODO: attempt to remove monobehavior from this class once we don't need to see the radius anymore
{
    public float radius = 3f;
    public ItemType itemType;
    public int amount;

    public enum ItemType
    {
        SampleItem,
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}

using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Wallet wallet = other.GetComponent<Wallet>();

            if (wallet != null)
            {
                wallet.AddCoin();
            }

            Destroy(gameObject);
        }
    }
}
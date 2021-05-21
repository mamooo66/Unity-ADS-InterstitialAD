using UnityEngine;
using UnityEngine.Advertisements;

public class InterstitialADS : MonoBehaviour  {
    public string GameID = "1111111";
    public string InterstitialPlacementID = "video";
    public bool testModu = false;
 
    private bool interstitialGosterilecek = false;
 
    void Start()
    {
        // Unity Ads'i kullanıma hazır hale getir
        Advertisement.Initialize( GameID, testModu );
    }
 
    void Update()
    {
        if( interstitialGosterilecek )
        {
            // Interstitial reklam gösterilmeye hazır mı diye kontrol et
            if( Advertisement.IsReady( InterstitialPlacementID ) )
            {
                // Interstitial reklam gösterilmeye hazır, o halde reklamı göster!
                Advertisement.Show( InterstitialPlacementID );
 
                // Interstitial'ı gösterdik, artık bu if koşulunu kontrol etmemize gerek yok
                interstitialGosterilecek = false;
            }
        }
    }
 
    public void InterstitialGoster()
    {
        interstitialGosterilecek = true;
    }
}

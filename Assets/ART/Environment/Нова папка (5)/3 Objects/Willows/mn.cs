using UnityEngine;
using UnityEngine.SceneManagement;
public class mn : MonoBehaviour
{ // Start is called before the first frame update
  
 void Start() { PlayerPrefs.SetString("lastLevel", SceneManager.GetActiveScene().name); }
}

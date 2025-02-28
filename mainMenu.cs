using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;


public class mainMenu : MonoBehaviour
{
   public void gotoGame(){
        StartCoroutine(WaitForSoundAndTransition("GamePlay");
        //SceneManager.LoadScene("GamePlay");
    }
    private IEnumerator WaitForSoundAndTransition(string sceneName)
    {
        AudioSource audio = GetComponentInChildren<AudioSource>();
        audio.Play();
        yield return new WaitForSeconds(audio.clip.length);
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }
}

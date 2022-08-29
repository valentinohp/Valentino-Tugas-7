using ForestView.Audio;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace ForestView.Scene
{
    public class MenuLauncher : MonoBehaviour
    {
        [SerializeField] private Button _playAudioButton;
        [SerializeField] private Button _playNoAudioButton;

        private void Start()
        {
            _playAudioButton.onClick.RemoveAllListeners();
            _playNoAudioButton.onClick.RemoveAllListeners();
            _playAudioButton.onClick.AddListener(OnWithAudioButtonClicked);
            _playNoAudioButton.onClick.AddListener(OnWithoutAudioButtonClicked);
        }

        private void OnWithAudioButtonClicked()
        {
            AudioManager.Instance.isAudioEnabled = true;
            SceneManager.LoadScene("Game");
        }
        
        private void OnWithoutAudioButtonClicked()
        {
            AudioManager.Instance.isAudioEnabled = false;
            SceneManager.LoadScene("Game");
        }
    }
}

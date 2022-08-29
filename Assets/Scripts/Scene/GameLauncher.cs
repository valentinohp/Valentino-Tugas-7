using ForestView.Audio;
using UnityEngine;

namespace ForestView.Scene
{
    public class GameLauncher : MonoBehaviour
    {
        private void Start()
        {
            if (AudioManager.Instance.isAudioEnabled)
            {
                AudioManager.Instance.PlayBgm();
            }
            else
            {
                AudioManager.Instance.NoBGM();
            }
        }
    }
}

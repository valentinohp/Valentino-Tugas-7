using System.Collections.Generic;
using UnityEngine;

namespace ForestView.Audio
{
    public class AudioManager : MonoBehaviour
    {
        [SerializeField] private List<AudioSource> _bgmAudioSource;
        public bool isAudioEnabled = false;
        private static AudioManager _instance;

        public static AudioManager Instance { get { return _instance; } }

        private void Awake()
        {
            if (_instance != null && _instance != this)
            {
                Destroy(this.gameObject);
            }
            else
            {
                _instance = this;
                DontDestroyOnLoad(this);
            }
        }

        public void PlayBgm()
        {
            int bgm = Random.Range(0, _bgmAudioSource.Count);
            _bgmAudioSource[bgm].Play();

            for (int i = 0; i < _bgmAudioSource.Count; i++)
            {
                if (i == bgm)
                {
                    _bgmAudioSource[i].clip.LoadAudioData();
                }
                else
                {
                    _bgmAudioSource[i].clip.UnloadAudioData();
                    Destroy(_bgmAudioSource[i].gameObject);
                }
            }
        }

        public void NoBGM()
        {
            for (int i = 0; i < _bgmAudioSource.Count; i++)
            {
                _bgmAudioSource[i].clip.UnloadAudioData();
                Destroy(_bgmAudioSource[i].gameObject);
            }
            _bgmAudioSource = null;
        }
    }
}

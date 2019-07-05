﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace VP_Project
{
    [Serializable]
    public class Sounds
    {
        private SoundPlayer shootingSound;
        private SoundPlayer MainMusic;
        private SoundPlayer buttonClick;
        public Sounds()
        {
            MainMusic = new SoundPlayer(Properties.Resources.BackgroundMusic);
            buttonClick = new SoundPlayer(Properties.Resources.buttonclicksound);
            shootingSound = new SoundPlayer(Properties.Resources.shootingSound);
        }
        public void playMainMusic()
        {
            MainMusic.PlayLooping();
        }
        public void playButtonClick()
        {
            buttonClick.Play();
        }

        public void playShootingSound()
        {
            shootingSound.Play();
        }

        public void stopShootingSound()
        {
            shootingSound.Stop();
        }
    }
    
}

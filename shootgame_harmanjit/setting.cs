using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shootgame_harmanjit
{
   public class setting
    {
        //global variable 
        int y = 0,fr=0,z=0,shtfr=0;

        Number N_Object= new Number();

        // fire button that is used to try 
        public int fire() {
            y++;
            if (y==1) {
                fr = N_Object.rnd();
            }
            if (y==fr) {
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(shootgame_harmanjit.Properties.Resources.GUN_FIRE_GoodSoundForYou_820112263);
                snd.Play();
            }
            if (y == 6)
            {
                return 0;
            }
            else {
                return 1;
            }
        }

        //shoot away button that is useed to perform the task of the 2nd chance 
        public int shootaway() {
            z++;
            if (z==1) {
                shtfr = N_Object.Shootrnd();
            }

            if (z == shtfr)
            {
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(shootgame_harmanjit.Properties.Resources.GUN_FIRE_GoodSoundForYou_820112263);
                snd.Play();

                return 0;
            }
            else {
                return 1;
            }
        }
    }
}

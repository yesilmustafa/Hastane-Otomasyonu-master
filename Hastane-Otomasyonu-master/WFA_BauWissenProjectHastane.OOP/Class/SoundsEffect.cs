using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace WFA_BauWissenProjectHastane.OOP.Class
{
    public class SoundsEffect
    {
        public static SoundPlayer clickeffect { get; set; } = new SoundPlayer(Properties.Resources.Mouse_Click_1__One_Click_Quick__Youtube_Video_Sound_Effects);
        public static SoundPlayer trueeffect { get; set; } = new SoundPlayer(Properties.Resources.True_question_correct_answer_sound_effect);
        public static SoundPlayer falseeffect { get; set; } = new SoundPlayer(Properties.Resources.False_question_incorrect_answer_sound_effect);
    }
}

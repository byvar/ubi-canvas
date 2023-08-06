using UbiArt.Animation;

namespace UbiArt.ITF {
	public partial class SubAnim_Template {
		public AnimTrack anim;

		protected override void OnPostSerialize(CSerializerObject s) {
			base.OnPostSerialize(s);
			if (name != null && IsFirstLoad) {
				Loader l = s.Context.Loader;
				if (l.LoadAnimations) {
					l.LoadFile<AnimTrack>(name, result => anim = result);
				}
				AddToStringCache(s);
			}
			if (s.Settings.game == Settings.Game.RJR || s.Settings.game == Settings.Game.RFR || s.Settings.game == Settings.Game.RO) {
				metronome = (METRONOME_TYPE)(int)metronome2;
				metronome3 = (METRONOME_TYPE3)(int)metronome2;
			} else if (s.Settings.game == Settings.Game.COL || s.Settings.game == Settings.Game.RL) {
				metronome = (METRONOME_TYPE)(int)metronome3;
				metronome2 = (METRONOME_TYPE2)(int)metronome3;
				forceZOffset = forceZOffset2 == BOOL._true;
			} else {
				metronome2 = (METRONOME_TYPE2)(int)metronome;
				metronome3 = (METRONOME_TYPE3)(int)metronome;
				forceZOffset2 = forceZOffset ? BOOL._true : BOOL._false;
			}
		}

		protected void AddToStringCache(CSerializerObject s) {
			if (!string.IsNullOrWhiteSpace(name?.filename)) {
				var newname = name.filename;
				if(newname.EndsWith(".anm")) newname = newname.Substring(0, newname.Length - 4);
				s.Context.AddToStringCache(newname);
			}
		}
	}
}

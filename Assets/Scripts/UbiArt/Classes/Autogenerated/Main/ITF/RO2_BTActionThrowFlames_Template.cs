using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BTActionThrowFlames_Template : BTAction_Template {
		[Serialize("animation"    )] public StringID animation;
		[Serialize("endAnimation" )] public StringID endAnimation;
		[Serialize("fxNames"      )] public Placeholder fxNames;
		[Serialize("fxMarkerStart")] public Placeholder fxMarkerStart;
		[Serialize("fxMarkerStop" )] public Placeholder fxMarkerStop;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(animation));
				SerializeField(s, nameof(endAnimation));
				SerializeField(s, nameof(fxNames));
				SerializeField(s, nameof(fxMarkerStart));
				SerializeField(s, nameof(fxMarkerStop));
			} else {
				SerializeField(s, nameof(animation));
				SerializeField(s, nameof(endAnimation));
			}
		}
		public override uint? ClassCRC => 0xB64EF794;
	}
}


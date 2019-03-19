using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RO | GameFlags.RL)]
	public partial class UISliderComponent_Template : UIItemBasic_Template {
		[Serialize("scaleOnSelected")] public float scaleOnSelected;
		[Serialize("isCursor"       )] public int isCursor;
		[Serialize("colorOnSelected")] public Color colorOnSelected;
		[Serialize("speedCursor"    )] public float speedCursor;
		[Serialize("scalefactor"    )] public float scalefactor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(scaleOnSelected));
				SerializeField(s, nameof(isCursor));
				SerializeField(s, nameof(colorOnSelected));
				SerializeField(s, nameof(speedCursor));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(scalefactor));
				SerializeField(s, nameof(speedCursor));
			} else {
			}
		}
		public override uint? ClassCRC => 0xD9999111;
	}
}


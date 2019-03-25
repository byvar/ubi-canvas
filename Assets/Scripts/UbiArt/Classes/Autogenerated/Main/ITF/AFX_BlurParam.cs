using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class AFX_BlurParam : CSerializable {
		[Serialize("use"      )] public bool use;
		[Serialize("pixelSize")] public float pixelSize;
		[Serialize("bigBlur"  )] public bool bigBlur;
		[Serialize("pixelSize")] public uint pixelSize2;
		[Serialize("quality"  )] public uint quality;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				if (Settings.s.game == Settings.Game.COL) {
					SerializeField(s, nameof(use), boolAsByte: true);
				} else {
					SerializeField(s, nameof(use));
				}
				SerializeField(s, nameof(pixelSize2));
				SerializeField(s, nameof(quality));
			} else {
				SerializeField(s, nameof(use));
				SerializeField(s, nameof(pixelSize));
				SerializeField(s, nameof(bigBlur));
			}
		}
	}
}


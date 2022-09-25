using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class AFX_BlurParam : CSerializable {
		public bool use;
		public float pixelSize;
		public bool bigBlur;
		public uint pixelSize2;
		public uint quality;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL || s.Settings.game == Settings.Game.COL) {
				if (s.Settings.game == Settings.Game.COL) {
					use = s.Serialize<bool>(use, name: "use", options: CSerializerObject.Options.BoolAsByte);
				} else {
					use = s.Serialize<bool>(use, name: "use");
				}
				pixelSize2 = s.Serialize<uint>(pixelSize2, name: "pixelSize");
				quality = s.Serialize<uint>(quality, name: "quality");
			} else {
				use = s.Serialize<bool>(use, name: "use");
				pixelSize = s.Serialize<float>(pixelSize, name: "pixelSize");
				bigBlur = s.Serialize<bool>(bigBlur, name: "bigBlur");
			}
		}
	}
}


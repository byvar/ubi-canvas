using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class FillConfig : CSerializable {
		[Serialize("smoothFactor")] public float smoothFactor;
		[Serialize("offset"      )] public float offset;
		[Serialize("angle"       )] public Angle angle;
		[Serialize("scale"       )] public Vector2 scale;
		[Serialize("tex"         )] public StringID tex;
		[Serialize("zExtrude"    )] public float zExtrude;
		[Serialize("isSmooth"    )] public bool isSmooth;
		[Serialize("texIndex"    )] public int texIndex;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(smoothFactor));
			SerializeField(s, nameof(offset));
			SerializeField(s, nameof(angle));
			SerializeField(s, nameof(scale));
			SerializeField(s, nameof(tex));
			SerializeField(s, nameof(zExtrude));
			if (s.HasFlags(SerializeFlags.Flags10)) {
				if (Settings.s.game == Settings.Game.COL) {
					SerializeField(s, nameof(isSmooth), boolAsByte: true);
				} else {
					SerializeField(s, nameof(isSmooth));
				}
				SerializeField(s, nameof(texIndex));
			}
		}
	}
}


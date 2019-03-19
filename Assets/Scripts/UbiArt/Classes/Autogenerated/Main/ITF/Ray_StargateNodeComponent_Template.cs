using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_StargateNodeComponent_Template : CSerializable {
		[Serialize("type"          )] public STARGATENODETYPE type;
		[Serialize("fadeTime"      )] public float fadeTime;
		[Serialize("fadeLength"    )] public float fadeLength;
		[Serialize("timeMultiplier")] public float timeMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(type));
			SerializeField(s, nameof(fadeTime));
			SerializeField(s, nameof(fadeLength));
			SerializeField(s, nameof(timeMultiplier));
		}
		public enum STARGATENODETYPE {
			[Serialize("STARGATENODETYPE_POINT"   )] POINT = 0,
			[Serialize("STARGATENODETYPE_TELEPORT")] TELEPORT = 1,
		}
		public override uint? ClassCRC => 0x1F1C5944;
	}
}


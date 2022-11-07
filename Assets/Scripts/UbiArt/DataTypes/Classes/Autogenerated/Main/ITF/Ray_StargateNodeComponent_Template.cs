namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_StargateNodeComponent_Template : CSerializable {
		public STARGATENODETYPE type;
		public float fadeTime;
		public float fadeLength;
		public float timeMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			type = s.Serialize<STARGATENODETYPE>(type, name: "type");
			fadeTime = s.Serialize<float>(fadeTime, name: "fadeTime");
			fadeLength = s.Serialize<float>(fadeLength, name: "fadeLength");
			timeMultiplier = s.Serialize<float>(timeMultiplier, name: "timeMultiplier");
		}
		public enum STARGATENODETYPE {
			[Serialize("STARGATENODETYPE_POINT"   )] POINT = 0,
			[Serialize("STARGATENODETYPE_TELEPORT")] TELEPORT = 1,
		}
		public override uint? ClassCRC => 0x1F1C5944;
	}
}


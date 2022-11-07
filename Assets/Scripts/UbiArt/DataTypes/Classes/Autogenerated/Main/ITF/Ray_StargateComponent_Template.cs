namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_StargateComponent_Template : CSerializable {
		public float speed;
		public StringID boneStart;
		public StringID teleportArea;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			speed = s.Serialize<float>(speed, name: "speed");
			boneStart = s.SerializeObject<StringID>(boneStart, name: "boneStart");
			teleportArea = s.SerializeObject<StringID>(teleportArea, name: "teleportArea");
		}
		public override uint? ClassCRC => 0xB26BD4F9;
	}
}


namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR)]
	public partial class Ray_ScaleFunnelComponent_Template : CSerializable {
		public float scale;
		public float suckMinTime;
		public float suckMaxTime;
		public float suckMaxSpeed;
		public float exitDistance;
		public StringID enterRegion;
		public StringID enterPoint;
		public StringID exitPoint;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			scale = s.Serialize<float>(scale, name: "scale");
			suckMinTime = s.Serialize<float>(suckMinTime, name: "suckMinTime");
			suckMaxTime = s.Serialize<float>(suckMaxTime, name: "suckMaxTime");
			suckMaxSpeed = s.Serialize<float>(suckMaxSpeed, name: "suckMaxSpeed");
			exitDistance = s.Serialize<float>(exitDistance, name: "exitDistance");
			enterRegion = s.SerializeObject<StringID>(enterRegion, name: "enterRegion");
			enterPoint = s.SerializeObject<StringID>(enterPoint, name: "enterPoint");
			exitPoint = s.SerializeObject<StringID>(exitPoint, name: "exitPoint");
		}
		public override uint? ClassCRC => 0x530FEE11;
	}
}


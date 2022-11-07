namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_ExtraLumsComponent_Template : ActorComponent_Template {
		public uint lumsCount;
		public float disappearStartTime;
		public float disappearIntervalTime;
		public float lumsDistance;
		public float lumsScale;
		public Angle lumsRotationSpeed;
		public StringID attachedBone;
		public StringID lumsAnimAppear;
		public StringID lumsAnimStand;
		public StringID lumsAnimDisappear;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			lumsCount = s.Serialize<uint>(lumsCount, name: "lumsCount");
			disappearStartTime = s.Serialize<float>(disappearStartTime, name: "disappearStartTime");
			disappearIntervalTime = s.Serialize<float>(disappearIntervalTime, name: "disappearIntervalTime");
			lumsDistance = s.Serialize<float>(lumsDistance, name: "lumsDistance");
			lumsScale = s.Serialize<float>(lumsScale, name: "lumsScale");
			lumsRotationSpeed = s.SerializeObject<Angle>(lumsRotationSpeed, name: "lumsRotationSpeed");
			attachedBone = s.SerializeObject<StringID>(attachedBone, name: "attachedBone");
			lumsAnimAppear = s.SerializeObject<StringID>(lumsAnimAppear, name: "lumsAnimAppear");
			lumsAnimStand = s.SerializeObject<StringID>(lumsAnimStand, name: "lumsAnimStand");
			lumsAnimDisappear = s.SerializeObject<StringID>(lumsAnimDisappear, name: "lumsAnimDisappear");
		}
		public override uint? ClassCRC => 0x46EA8D63;
	}
}


namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_HeadBranchComponent_Template : RO2_BezierBranchComponent_Template {
		public Path headActor;
		public float headAttachOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			headActor = s.SerializeObject<Path>(headActor, name: "headActor");
			headAttachOffset = s.Serialize<float>(headAttachOffset, name: "headAttachOffset");
		}
		public override uint? ClassCRC => 0xAA947DB6;
	}
}


namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_FishSwarmAIComponent : RO2_AIComponent {
		public uint numFishPerColumn;
		public uint numColumn;
		public float borderForceUp;
		public float borderForceDown;
		public float borderForceRight;
		public float borderForceLeft;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				numFishPerColumn = s.Serialize<uint>(numFishPerColumn, name: "numFishPerColumn");
				numColumn = s.Serialize<uint>(numColumn, name: "numColumn");
				borderForceUp = s.Serialize<float>(borderForceUp, name: "borderForceUp");
				borderForceDown = s.Serialize<float>(borderForceDown, name: "borderForceDown");
				borderForceRight = s.Serialize<float>(borderForceRight, name: "borderForceRight");
				borderForceLeft = s.Serialize<float>(borderForceLeft, name: "borderForceLeft");
			}
		}
		public override uint? ClassCRC => 0x07764263;
	}
}


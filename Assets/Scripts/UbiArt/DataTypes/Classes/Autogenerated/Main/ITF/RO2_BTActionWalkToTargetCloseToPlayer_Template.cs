namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionWalkToTargetCloseToPlayer_Template : BTActionWalkToTarget_Template {
		public float checkIntervals = 0.5f;
		public float rangeMin = -2f;
		public float rangeMax = 10f;
		public float maxSpeed = 1.5f;
		public float minSpeed = 0.8f;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			checkIntervals = s.Serialize<float>(checkIntervals, name: "checkIntervals");
			rangeMin = s.Serialize<float>(rangeMin, name: "rangeMin");
			rangeMax = s.Serialize<float>(rangeMax, name: "rangeMax");
			maxSpeed = s.Serialize<float>(maxSpeed, name: "maxSpeed");
			minSpeed = s.Serialize<float>(minSpeed, name: "minSpeed");
		}
		public override uint? ClassCRC => 0xA5041CD8;
	}
}


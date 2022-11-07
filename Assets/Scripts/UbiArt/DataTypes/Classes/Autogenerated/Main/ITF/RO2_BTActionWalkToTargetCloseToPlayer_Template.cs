namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionWalkToTargetCloseToPlayer_Template : BTActionWalkToTarget_Template {
		public float checkIntervals;
		public float rangeMin;
		public float rangeMax;
		public float maxSpeed;
		public float minSpeed;
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


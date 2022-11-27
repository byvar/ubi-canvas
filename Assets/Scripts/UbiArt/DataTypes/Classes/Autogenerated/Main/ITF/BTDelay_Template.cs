namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class BTDelay_Template : BTNode_Template {
		public float minTime = 1f;
		public float maxTime = 2f;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			minTime = s.Serialize<float>(minTime, name: "minTime");
			maxTime = s.Serialize<float>(maxTime, name: "maxTime");
		}
		public override uint? ClassCRC => 0x0968EAE6;
	}
}


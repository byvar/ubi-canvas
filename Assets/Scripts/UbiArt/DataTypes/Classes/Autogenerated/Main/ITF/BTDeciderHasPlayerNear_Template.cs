namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class BTDeciderHasPlayerNear_Template : BTDecider_Template {
		public StringID fact;
		public float radius = 2f;
		public StringID detectionArea;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			fact = s.SerializeObject<StringID>(fact, name: "fact");
			radius = s.Serialize<float>(radius, name: "radius");
			detectionArea = s.SerializeObject<StringID>(detectionArea, name: "detectionArea");
		}
		public override uint? ClassCRC => 0x00F2FC64;
	}
}


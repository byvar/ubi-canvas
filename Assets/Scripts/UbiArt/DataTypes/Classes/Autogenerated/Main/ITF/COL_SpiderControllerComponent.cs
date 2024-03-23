namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_SpiderControllerComponent : ActorComponent {
		public float travelDistance;
		public float idleDuration;
		public float travelDurationUp;
		public float travelDurationDown;
		public int useWeb;
		public bool easeInDownMove;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			travelDistance = s.Serialize<float>(travelDistance, name: "travelDistance");
			idleDuration = s.Serialize<float>(idleDuration, name: "idleDuration");
			travelDurationUp = s.Serialize<float>(travelDurationUp, name: "travelDurationUp");
			travelDurationDown = s.Serialize<float>(travelDurationDown, name: "travelDurationDown");
			useWeb = s.Serialize<int>(useWeb, name: "useWeb");
			easeInDownMove = s.Serialize<bool>(easeInDownMove, name: "easeInDownMove", options: CSerializerObject.Options.BoolAsByte);
		}
		public override uint? ClassCRC => 0x522EFC51;
	}
}


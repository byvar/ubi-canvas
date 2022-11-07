namespace UbiArt.online {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class GameGlobalsIAPPredictionCondition : GameGlobalsCondition {
		public float minThreshold;
		public float maxThreshold;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			minThreshold = s.Serialize<float>(minThreshold, name: "minThreshold");
			maxThreshold = s.Serialize<float>(maxThreshold, name: "maxThreshold");
		}
		public override uint? ClassCRC => 0xB1C4F5EB;
	}
}


namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_DRCTrappedComponent : ActorComponent {
		public int isTrapped;
		public Path DRCTriggerPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			isTrapped = s.Serialize<int>(isTrapped, name: "isTrapped");
			DRCTriggerPath = s.SerializeObject<Path>(DRCTriggerPath, name: "DRCTriggerPath");
		}
		public override uint? ClassCRC => 0xC62AF726;
	}
}


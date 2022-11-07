namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class EventGhostHitTrigger : EventTrigger {
		public bool triggeredByCollision;
		public bool triggeredByHitStim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			triggeredByCollision = s.Serialize<bool>(triggeredByCollision, name: "triggeredByCollision");
			triggeredByHitStim = s.Serialize<bool>(triggeredByHitStim, name: "triggeredByHitStim");
		}
		public override uint? ClassCRC => 0x824DC666;
	}
}


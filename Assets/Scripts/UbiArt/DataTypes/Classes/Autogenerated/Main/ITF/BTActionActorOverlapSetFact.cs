namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class BTActionActorOverlapSetFact : BTAction {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xA3660E59;
	}
}


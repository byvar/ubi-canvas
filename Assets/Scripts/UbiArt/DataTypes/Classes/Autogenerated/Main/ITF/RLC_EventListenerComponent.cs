namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class RLC_EventListenerComponent : ActorComponent {
		public bool TransfertEventToChildren;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			TransfertEventToChildren = s.Serialize<bool>(TransfertEventToChildren, name: "TransfertEventToChildren");
		}
		public override uint? ClassCRC => 0xCFAA85B0;
	}
}


namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class AIFollowCollideActorAction : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x1749113E;
	}
}


namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class AIFollowActorAction : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xC6F78EC0;
	}
}


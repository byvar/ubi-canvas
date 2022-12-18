namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_HomeRoomComponent_Template : ActorComponent_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x6E14C190;
	}
}


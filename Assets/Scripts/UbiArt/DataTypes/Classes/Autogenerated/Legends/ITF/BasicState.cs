namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion | GameFlags.RM)]
	public partial class BasicState : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x4615A50F;
	}
}


namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class RLC_GS_AdventureMap : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xB55D9B54;
	}
}


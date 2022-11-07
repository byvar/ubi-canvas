namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class RLC_BasicButton_Template : ActorComponent_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x374089DC;
	}
}


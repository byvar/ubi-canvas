namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion | GameFlags.RM)]
	public partial class PhysForceModifierBox : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x557F3761;
	}
}


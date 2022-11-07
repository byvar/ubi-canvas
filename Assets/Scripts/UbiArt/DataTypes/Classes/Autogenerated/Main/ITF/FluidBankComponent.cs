namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class FluidBankComponent : GraphicComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xF7488362;
	}
}


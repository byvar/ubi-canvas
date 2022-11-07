namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_ForceFieldComponent : GraphicComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xE75681CB;
	}
}


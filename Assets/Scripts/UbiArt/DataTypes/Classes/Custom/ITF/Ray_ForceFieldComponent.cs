namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_ForceFieldComponent : GraphicComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x341013E5;
	}
}


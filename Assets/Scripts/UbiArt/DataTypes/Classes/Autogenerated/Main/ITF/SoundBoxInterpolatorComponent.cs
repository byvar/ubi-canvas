namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class SoundBoxInterpolatorComponent : BoxInterpolatorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xB171C5E5;
	}
}


namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class BezierBranchBaseRendererComponent : BezierBranchComponent {
		public bool flipTexture;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			flipTexture = s.Serialize<bool>(flipTexture, name: "flipTexture");
		}
		public override uint? ClassCRC => 0x5EB81DE3;
	}
}


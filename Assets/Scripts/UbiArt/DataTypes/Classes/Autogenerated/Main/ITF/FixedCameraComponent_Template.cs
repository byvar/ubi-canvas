namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class FixedCameraComponent_Template : BaseCameraComponent_Template {
		public float zOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RO) {
				zOffset = s.Serialize<float>(zOffset, name: "zOffset");
			} else {
			}
		}
		public override uint? ClassCRC => 0xC4B49CE8;
	}
}


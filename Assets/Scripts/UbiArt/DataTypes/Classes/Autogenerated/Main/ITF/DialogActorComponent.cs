namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class DialogActorComponent : ActorComponent {
		public bool enableDialog;
		public Vec2d offset = new Vec2d(0, 1.4f);
		public bool is3D;
		public float widthTextAreaMax = 5f;
		public Vec2d offSetCorrectionPx;
		public Vec2d managerOffsetDelta;
		public Vec2d textOffset;
		public int snapToScreen;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.COL) {
				enableDialog = s.Serialize<bool>(enableDialog, name: "enableDialog");
				textOffset = s.SerializeObject<Vec2d>(textOffset, name: "textOffset");
				snapToScreen = s.Serialize<int>(snapToScreen, name: "snapToScreen");
				is3D = s.Serialize<bool>(is3D, name: "is3D");
				offSetCorrectionPx = s.SerializeObject<Vec2d>(offSetCorrectionPx, name: "offSetCorrectionPx");
			} else {
				enableDialog = s.Serialize<bool>(enableDialog, name: "enableDialog");
				offset = s.SerializeObject<Vec2d>(offset, name: "offset");
				is3D = s.Serialize<bool>(is3D, name: "is3D");
				widthTextAreaMax = s.Serialize<float>(widthTextAreaMax, name: "widthTextAreaMax");
				offSetCorrectionPx = s.SerializeObject<Vec2d>(offSetCorrectionPx, name: "offSetCorrectionPx");
				managerOffsetDelta = s.SerializeObject<Vec2d>(managerOffsetDelta, name: "managerOffsetDelta");
			}
		}
		public override uint? ClassCRC => 0x19FA44DD;
	}
}


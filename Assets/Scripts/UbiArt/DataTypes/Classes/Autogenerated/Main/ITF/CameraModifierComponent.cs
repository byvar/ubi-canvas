namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class CameraModifierComponent : ActorComponent {
		public uint cameraView = 3;
		public bool ignoreAABB;
		public bool ignoreSceneActiveState;
		public CamModifier CM;
		public AABB localAABB;
		public CamModifierOverride CM_override;
		public float zTolerance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RJR || s.Settings.game == Settings.Game.RFR || s.Settings.game == Settings.Game.RO) {
				if (s.HasFlags(SerializeFlags.Default)) {
					CM = s.SerializeObject<CamModifier>(CM, name: "CM");
					CM_override = s.SerializeObject<CamModifierOverride>(CM_override, name: "CM_override");
				}
			} else if (s.Settings.game == Settings.Game.RL || s.Settings.game == Settings.Game.VH) {
				if (s.HasFlags(SerializeFlags.Default)) {
					cameraView = s.Serialize<uint>(cameraView, name: "cameraView");
					ignoreAABB = s.Serialize<bool>(ignoreAABB, name: "ignoreAABB");
					CM = s.SerializeObject<CamModifier>(CM, name: "CM");
				}
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					localAABB = s.SerializeObject<AABB>(localAABB, name: "localAABB");
				}
			} else if (s.Settings.game == Settings.Game.COL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					cameraView = s.Serialize<uint>(cameraView, name: "cameraView");
					ignoreAABB = s.Serialize<bool>(ignoreAABB, name: "ignoreAABB", options: CSerializerObject.Options.BoolAsByte);
					zTolerance = s.Serialize<float>(zTolerance, name: "zTolerance");
				}
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					localAABB = s.SerializeObject<AABB>(localAABB, name: "localAABB");
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					cameraView = s.Serialize<uint>(cameraView, name: "cameraView");
					ignoreAABB = s.Serialize<bool>(ignoreAABB, name: "ignoreAABB");
					ignoreSceneActiveState = s.Serialize<bool>(ignoreSceneActiveState, name: "ignoreSceneActiveState");
					CM = s.SerializeObject<CamModifier>(CM, name: "CM");
				}
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					localAABB = s.SerializeObject<AABB>(localAABB, name: "localAABB");
				}
			}
		}
		public override uint? ClassCRC => 0x6C8DD66E;
	}
}


namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class TextBoxAttachedToBoneComponent : ActorComponent {
		public StringID boneName;
		public bool useBoneScale;
		public bool useBoneAngle;
		public bool useBoneAlpha;
		public bool applyActorTransform;
		public Vec2d offset;
		public float angleOffset;
		public bool ForceSnappingExternalActor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RL || s.Settings.Game == Game.COL || s.Settings.Game == Game.VH) {
			} else {
				boneName = s.SerializeObject<StringID>(boneName, name: "boneName");
				useBoneScale = s.Serialize<bool>(useBoneScale, name: "useBoneScale");
				useBoneAngle = s.Serialize<bool>(useBoneAngle, name: "useBoneAngle");
				useBoneAlpha = s.Serialize<bool>(useBoneAlpha, name: "useBoneAlpha");
				applyActorTransform = s.Serialize<bool>(applyActorTransform, name: "applyActorTransform");
				offset = s.SerializeObject<Vec2d>(offset, name: "offset");
				angleOffset = s.Serialize<float>(angleOffset, name: "angleOffset");
				ForceSnappingExternalActor = s.Serialize<bool>(ForceSnappingExternalActor, name: "ForceSnappingExternalActor");
			}
		}
		public override uint? ClassCRC => 0xCC3D946A;
	}
}


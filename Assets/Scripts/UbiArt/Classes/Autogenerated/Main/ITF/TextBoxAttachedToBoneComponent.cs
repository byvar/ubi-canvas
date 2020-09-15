using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class TextBoxAttachedToBoneComponent : ActorComponent {
		[Serialize("boneName"                  )] public StringID boneName;
		[Serialize("useBoneScale"              )] public bool useBoneScale;
		[Serialize("useBoneAngle"              )] public bool useBoneAngle;
		[Serialize("useBoneAlpha"              )] public bool useBoneAlpha;
		[Serialize("applyActorTransform"       )] public bool applyActorTransform;
		[Serialize("offset"                    )] public Vec2d offset;
		[Serialize("angleOffset"               )] public float angleOffset;
		[Serialize("ForceSnappingExternalActor")] public bool ForceSnappingExternalActor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL || Settings.s.game == Settings.Game.VH) {
			} else {
				SerializeField(s, nameof(boneName));
				SerializeField(s, nameof(useBoneScale));
				SerializeField(s, nameof(useBoneAngle));
				SerializeField(s, nameof(useBoneAlpha));
				SerializeField(s, nameof(applyActorTransform));
				SerializeField(s, nameof(offset));
				SerializeField(s, nameof(angleOffset));
				SerializeField(s, nameof(ForceSnappingExternalActor));
			}
		}
		public override uint? ClassCRC => 0xCC3D946A;
	}
}


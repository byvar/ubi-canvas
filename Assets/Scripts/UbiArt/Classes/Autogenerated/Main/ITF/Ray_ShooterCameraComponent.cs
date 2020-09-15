using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_ShooterCameraComponent : BaseCameraComponent {
		[Serialize("Pos"            )] public Vec3d Pos;
		[Serialize("useInitModifier")] public bool useInitModifier;
		[Serialize("initModifier"   )] public Ray_ShooterCameraModifierComponent.ShooterCameraModifier initModifier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(Pos));
			}
			SerializeField(s, nameof(useInitModifier));
			if (useInitModifier) {
				SerializeField(s, nameof(initModifier));
			}
		}
		public override uint? ClassCRC => 0x69A494EA;
	}
}


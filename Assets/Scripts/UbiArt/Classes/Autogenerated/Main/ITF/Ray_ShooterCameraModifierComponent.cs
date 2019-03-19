using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_ShooterCameraModifierComponent : CSerializable {
		[Serialize("camModifier" )] public Placeholder camModifier;
		[Serialize("transitionIN")] public Placeholder transitionIN;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(camModifier));
			SerializeField(s, nameof(transitionIN));
		}
		public override uint? ClassCRC => 0x70E0C28B;
	}
}


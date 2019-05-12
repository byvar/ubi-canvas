using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_ShooterCameraModifierComponent : ActorComponent {
		[Serialize("camModifier" )] public ShooterCameraModifier camModifier;
		[Serialize("transitionIN")] public ShooterCameraModifier_Transition transitionIN;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(camModifier));
			SerializeField(s, nameof(transitionIN));
		}
		public override uint? ClassCRC => 0x70E0C28B;
		
		[Games(GameFlags.RO)]
		public partial class ShooterCameraModifier : CSerializable {
			[Serialize("moveSpeed")] public Vector2 moveSpeed;
			[Serialize("zOffset"  )] public float zOffset;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(moveSpeed));
				SerializeField(s, nameof(zOffset));
			}
		}

		[Games(GameFlags.RO)]
		public partial class ShooterCameraModifier_Transition : CSerializable {
			[Serialize("type"             )] public Enum_type type;
			[Serialize("duration"         )] public float duration;
			[Serialize("additionalSpeed"  )] public Vector2 additionalSpeed;
			[Serialize("notifyPlayerDelay")] public float notifyPlayerDelay;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(type));
				SerializeField(s, nameof(duration));
				SerializeField(s, nameof(additionalSpeed));
				SerializeField(s, nameof(notifyPlayerDelay));
			}
			public enum Enum_type {
				[Serialize("Linear"    )] Linear = 0,
				[Serialize("AccelDecel")] AccelDecel = 1,
				[Serialize("X2"        )] X2 = 2,
				[Serialize("InvX2"     )] InvX2 = 3,
				[Serialize("X3"        )] X3 = 4,
				[Serialize("InvX3"     )] InvX3 = 5,
			}
		}
	}
}


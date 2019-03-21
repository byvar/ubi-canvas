using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_ScreenBorderMissileComponent : ActorComponent {
		[Serialize("border"            )] public ScreenBorder border;
		[Serialize("borderOffset"      )] public float borderOffset;
		[Serialize("corridorWidth"     )] public float corridorWidth;
		[Serialize("corridorSmooth"    )] public float corridorSmooth;
		[Serialize("waitingMaxDuration")] public float waitingMaxDuration;
		[Serialize("fireShakeDuration" )] public float fireShakeDuration;
		[Serialize("fireShakeAmplitude")] public float fireShakeAmplitude;
		[Serialize("fireShakeCount"    )] public uint fireShakeCount;
		[Serialize("fireSpeed"         )] public float fireSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(border));
			SerializeField(s, nameof(borderOffset));
			SerializeField(s, nameof(corridorWidth));
			SerializeField(s, nameof(corridorSmooth));
			SerializeField(s, nameof(waitingMaxDuration));
			SerializeField(s, nameof(fireShakeDuration));
			SerializeField(s, nameof(fireShakeAmplitude));
			SerializeField(s, nameof(fireShakeCount));
			SerializeField(s, nameof(fireSpeed));
		}
		public enum ScreenBorder {
			[Serialize("ScreenBorder_Left"  )] Left = 0,
			[Serialize("ScreenBorder_Right" )] Right = 1,
			[Serialize("ScreenBorder_Bottom")] Bottom = 2,
			[Serialize("ScreenBorder_Top"   )] Top = 3,
		}
		public override uint? ClassCRC => 0x10DD06F8;
	}
}


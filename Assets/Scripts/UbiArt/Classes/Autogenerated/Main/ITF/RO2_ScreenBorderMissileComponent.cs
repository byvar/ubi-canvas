using UnityEngine;

namespace UbiArt.ITF {
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
		[Serialize("border"            )] public Enum_border border;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(border));
				SerializeField(s, nameof(borderOffset));
				SerializeField(s, nameof(corridorWidth));
				SerializeField(s, nameof(corridorSmooth));
				SerializeField(s, nameof(waitingMaxDuration));
				SerializeField(s, nameof(fireShakeDuration));
				SerializeField(s, nameof(fireShakeAmplitude));
				SerializeField(s, nameof(fireShakeCount));
				SerializeField(s, nameof(fireSpeed));
			} else {
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
		}
		public enum ScreenBorder {
			[Serialize("ScreenBorder_Left"  )] Left = 0,
			[Serialize("ScreenBorder_Right" )] Right = 1,
			[Serialize("ScreenBorder_Bottom")] Bottom = 2,
			[Serialize("ScreenBorder_Top"   )] Top = 3,
		}
		public enum Enum_border {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
		}
		public override uint? ClassCRC => 0x10DD06F8;
	}
}


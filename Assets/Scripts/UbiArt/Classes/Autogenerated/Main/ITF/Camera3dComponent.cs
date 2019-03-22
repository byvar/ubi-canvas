using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class Camera3dComponent : ActorComponent {
		[Serialize("fadeInSmoothA" )] public float fadeInSmoothA;
		[Serialize("fadeOutSmoothA")] public float fadeOutSmoothA;
		[Serialize("viewMode"      )] public ViewMode viewMode;
		[Serialize("fadeInSmooth"  )] public float fadeInSmooth;
		[Serialize("fadeOutSmooth" )] public float fadeOutSmooth;
		[Serialize("deltaFogZ"     )] public float deltaFogZ;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags8)) {
				SerializeField(s, nameof(fadeInSmoothA));
				SerializeField(s, nameof(fadeOutSmoothA));
			}
			SerializeField(s, nameof(viewMode));
			SerializeField(s, nameof(fadeInSmooth));
			SerializeField(s, nameof(fadeOutSmooth));
			SerializeField(s, nameof(deltaFogZ));
		}
		public enum ViewMode {
			[Serialize("ViewMode_Main"  )] Main = 1,
			[Serialize("ViewMode_Remote")] Remote = 2,
			[Serialize("ViewMode_Both"  )] Both = 3,
		}
		public override uint? ClassCRC => 0x90296FE0;
	}
}


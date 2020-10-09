using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class Camera3dComponent : ActorComponent {
		public float fadeInSmoothA;
		public float fadeOutSmoothA;
		public ViewMode viewMode;
		public float fadeInSmooth;
		public float fadeOutSmooth;
		public float deltaFogZ;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags8)) {
				fadeInSmoothA = s.Serialize<float>(fadeInSmoothA, name: "fadeInSmoothA");
				fadeOutSmoothA = s.Serialize<float>(fadeOutSmoothA, name: "fadeOutSmoothA");
			}
			viewMode = s.Serialize<ViewMode>(viewMode, name: "viewMode");
			fadeInSmooth = s.Serialize<float>(fadeInSmooth, name: "fadeInSmooth");
			fadeOutSmooth = s.Serialize<float>(fadeOutSmooth, name: "fadeOutSmooth");
			deltaFogZ = s.Serialize<float>(deltaFogZ, name: "deltaFogZ");
		}
		public enum ViewMode {
			[Serialize("ViewMode_Main"  )] Main = 1,
			[Serialize("ViewMode_Remote")] Remote = 2,
			[Serialize("ViewMode_Both"  )] Both = 3,
		}
		public override uint? ClassCRC => 0x90296FE0;
	}
}


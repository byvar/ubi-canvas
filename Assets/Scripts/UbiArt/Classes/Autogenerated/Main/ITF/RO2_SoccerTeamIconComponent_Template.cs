using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_SoccerTeamIconComponent_Template : GraphicComponent_Template {
		[Serialize("transitionTime")] public float transitionTime;
		[Serialize("frameMaterial" )] public GFXMaterialSerializable frameMaterial;
		[Serialize("frameSize"     )] public Vector2 frameSize;
		[Serialize("luigiMaterial" )] public GFXMaterialSerializable luigiMaterial;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(transitionTime));
				SerializeField(s, nameof(frameMaterial));
				SerializeField(s, nameof(frameSize));
				SerializeField(s, nameof(luigiMaterial));
			} else {
				SerializeField(s, nameof(transitionTime));
				SerializeField(s, nameof(frameMaterial));
				SerializeField(s, nameof(frameSize));
			}
		}
		public override uint? ClassCRC => 0xEE1D6665;
	}
}


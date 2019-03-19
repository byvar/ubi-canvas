using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class PadRumble : CSerializable {
		[Serialize("name"          )] public StringID name;
		[Serialize("intensity"     )] public float intensity;
		[Serialize("lightIntensity")] public float lightIntensity;
		[Serialize("duration"      )] public float duration;
		[Serialize("StringID__0"   )] public StringID StringID__0;
		[Serialize("float__1"      )] public float float__1;
		[Serialize("float__2"      )] public float float__2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(StringID__0));
				SerializeField(s, nameof(float__1));
				SerializeField(s, nameof(float__2));
			} else {
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(intensity));
				SerializeField(s, nameof(lightIntensity));
				SerializeField(s, nameof(duration));
			}
		}
	}
}


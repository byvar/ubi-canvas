using UnityEngine;

namespace UbiArt.ITF {
	public partial class FxData : CSerializable {
		[Serialize("fxFall"      )] public StringID fxFall;
		[Serialize("fxHit"       )] public StringID fxHit;
		[Serialize("fxSteam"     )] public StringID fxSteam;
		[Serialize("soundFall"   )] public StringID soundFall;
		[Serialize("soundHit"    )] public StringID soundHit;
		[Serialize("soundDestroy")] public StringID soundDestroy;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(fxFall));
			SerializeField(s, nameof(fxHit));
			SerializeField(s, nameof(fxSteam));
			SerializeField(s, nameof(soundFall));
			SerializeField(s, nameof(soundHit));
			SerializeField(s, nameof(soundDestroy));
		}
	}
}


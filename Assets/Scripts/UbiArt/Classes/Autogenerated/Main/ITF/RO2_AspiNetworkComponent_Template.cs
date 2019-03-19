using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_AspiNetworkComponent_Template : ActorComponent_Template {
		[Serialize("enterDuration"        )] public float enterDuration;
		[Serialize("enterBezierMultiplier")] public float enterBezierMultiplier;
		[Serialize("speed"                )] public float speed;
		[Serialize("exitSpeed"            )] public float exitSpeed;
		[Serialize("exitDist"             )] public float exitDist;
		[Serialize("exitRestoreZDist"     )] public float exitRestoreZDist;
		[Serialize("fxData"               )] public CList<RO2_AspiNetworkComponent_Template.FxDataNet> fxData;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(enterDuration));
			SerializeField(s, nameof(enterBezierMultiplier));
			SerializeField(s, nameof(speed));
			SerializeField(s, nameof(exitSpeed));
			SerializeField(s, nameof(exitDist));
			SerializeField(s, nameof(exitRestoreZDist));
			SerializeField(s, nameof(fxData));
		}
		[Games(GameFlags.RA)]
		public partial class FxDataNet : CSerializable {
			[Serialize("playerFamily")] public string playerFamily;
			[Serialize("fxIn"        )] public StringID fxIn;
			[Serialize("fxOut"       )] public StringID fxOut;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(playerFamily));
				SerializeField(s, nameof(fxIn));
				SerializeField(s, nameof(fxOut));
			}
		}
		public override uint? ClassCRC => 0x650F47CC;
	}
}


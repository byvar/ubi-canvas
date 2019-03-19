using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AspiNetworkComponent_Template : CSerializable {
		[Serialize("enterDuration"        )] public float enterDuration;
		[Serialize("enterBezierMultiplier")] public float enterBezierMultiplier;
		[Serialize("speed"                )] public float speed;
		[Serialize("exitSpeed"            )] public float exitSpeed;
		[Serialize("exitDist"             )] public float exitDist;
		[Serialize("exitRestoreZDist"     )] public float exitRestoreZDist;
		[Serialize("fxData"               )] public CList<Ray_AspiNetworkComponent_Template.FxData> fxData;
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
		[Games(GameFlags.RFR)]
		public partial class FxData : CSerializable {
			[Serialize("string__0"  )] public string string__0;
			[Serialize("StringID__1")] public StringID StringID__1;
			[Serialize("StringID__2")] public StringID StringID__2;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(string__0));
				SerializeField(s, nameof(StringID__1));
				SerializeField(s, nameof(StringID__2));
			}
		}
		public override uint? ClassCRC => 0x1DF730D4;
	}
}


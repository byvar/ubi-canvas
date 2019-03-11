using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_ChildLaunchComponent_Template : CSerializable {
		[Serialize("disableAfterLaunch"  )] public bool disableAfterLaunch;
		[Serialize("launchPolyline"      )] public StringID launchPolyline;
		[Serialize("hintFxPath"          )] public Path hintFxPath;
		[Serialize("hintFxInstantDestroy")] public bool hintFxInstantDestroy;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(disableAfterLaunch));
			SerializeField(s, nameof(launchPolyline));
			SerializeField(s, nameof(hintFxPath));
			SerializeField(s, nameof(hintFxInstantDestroy));
		}
		public override uint? ClassCRC => 0xDB92995B;
	}
}


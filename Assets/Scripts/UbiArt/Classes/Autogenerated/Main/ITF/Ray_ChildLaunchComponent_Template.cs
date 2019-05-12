using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_ChildLaunchComponent_Template : ActorComponent_Template {
		[Serialize("disableAfterLaunch"  )] public int disableAfterLaunch;
		[Serialize("launchPolyline"      )] public StringID launchPolyline;
		[Serialize("hintFxPath"          )] public Path hintFxPath;
		[Serialize("hintFxInstantDestroy")] public int hintFxInstantDestroy;
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


using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_ChildLaunchComponent_Template : ActorComponent_Template {
		public int disableAfterLaunch;
		public StringID launchPolyline;
		public Path hintFxPath;
		public int hintFxInstantDestroy;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			disableAfterLaunch = s.Serialize<int>(disableAfterLaunch, name: "disableAfterLaunch");
			launchPolyline = s.SerializeObject<StringID>(launchPolyline, name: "launchPolyline");
			hintFxPath = s.SerializeObject<Path>(hintFxPath, name: "hintFxPath");
			hintFxInstantDestroy = s.Serialize<int>(hintFxInstantDestroy, name: "hintFxInstantDestroy");
		}
		public override uint? ClassCRC => 0xDB92995B;
	}
}


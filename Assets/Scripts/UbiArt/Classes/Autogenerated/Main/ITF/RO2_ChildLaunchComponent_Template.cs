using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_ChildLaunchComponent_Template : ActorComponent_Template {
		public bool disableAfterLaunch;
		public StringID launchPolyline;
		public Path hintFxPath;
		public bool hintFxInstantDestroy;
		public bool triggerChildsOnTouch;
		public bool isPaintable;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			disableAfterLaunch = s.Serialize<bool>(disableAfterLaunch, name: "disableAfterLaunch");
			launchPolyline = s.SerializeObject<StringID>(launchPolyline, name: "launchPolyline");
			hintFxPath = s.SerializeObject<Path>(hintFxPath, name: "hintFxPath");
			hintFxInstantDestroy = s.Serialize<bool>(hintFxInstantDestroy, name: "hintFxInstantDestroy");
			triggerChildsOnTouch = s.Serialize<bool>(triggerChildsOnTouch, name: "triggerChildsOnTouch");
			isPaintable = s.Serialize<bool>(isPaintable, name: "isPaintable");
		}
		public override uint? ClassCRC => 0xA6C1E2D4;
	}
}


using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_ChildLaunchComponent_Template : ActorComponent_Template {
		[Serialize("disableAfterLaunch"  )] public bool disableAfterLaunch;
		[Serialize("launchPolyline"      )] public StringID launchPolyline;
		[Serialize("hintFxPath"          )] public Path hintFxPath;
		[Serialize("hintFxInstantDestroy")] public bool hintFxInstantDestroy;
		[Serialize("triggerChildsOnTouch")] public bool triggerChildsOnTouch;
		[Serialize("isPaintable"         )] public bool isPaintable;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(disableAfterLaunch));
			SerializeField(s, nameof(launchPolyline));
			SerializeField(s, nameof(hintFxPath));
			SerializeField(s, nameof(hintFxInstantDestroy));
			SerializeField(s, nameof(triggerChildsOnTouch));
			SerializeField(s, nameof(isPaintable));
		}
		public override uint? ClassCRC => 0xA6C1E2D4;
	}
}


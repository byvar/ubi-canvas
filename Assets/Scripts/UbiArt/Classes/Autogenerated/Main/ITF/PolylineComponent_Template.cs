using UnityEngine;

namespace UbiArt.ITF {
	public partial class PolylineComponent_Template : ActorComponent_Template {
		[Serialize("polylineParams"      )] public CList<PolylineParameters> polylineParams;
		[Serialize("isEnvironment"       )] public bool isEnvironment;
		[Serialize("computeLocalToGlobal")] public bool computeLocalToGlobal;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(polylineParams));
				SerializeField(s, nameof(computeLocalToGlobal));
			} else {
				SerializeField(s, nameof(polylineParams));
				SerializeField(s, nameof(isEnvironment));
			}
		}
		public override uint? ClassCRC => 0x72853946;
	}
}


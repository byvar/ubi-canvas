using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_LoadingTitleComponent_Template : ActorComponent_Template {
		[Serialize("textPath" )] public Path textPath;
		[Serialize("screenPos")] public Vector2 screenPos;
		[Serialize("locId"    )] public SmartLocId locId;
		[Serialize("homeLocId")] public SmartLocId homeLocId;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(textPath));
			SerializeField(s, nameof(screenPos));
			SerializeField(s, nameof(locId));
			SerializeField(s, nameof(homeLocId));
		}
		public override uint? ClassCRC => 0xB755C5E7;
	}
}


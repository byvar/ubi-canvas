using UnityEngine;

namespace UbiArt.ITF {
	public partial class UIButtonComponent_Template : UIComponent_Template {
		[Serialize("speed"                     )] public float speed;
		[Serialize("path"                      )] public Path path;
		[Serialize("idleSelectedScale"         )] public float idleSelectedScale;
		[Serialize("idleSelectedPulseFrequency")] public float idleSelectedPulseFrequency;
		[Serialize("is2dActor"                 )] public bool is2dActor;
		[Serialize("actorScaleSmoothFactor"    )] public float actorScaleSmoothFactor;
		[Serialize("minActorScale"             )] public float minActorScale;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(speed));
			SerializeField(s, nameof(path));
			SerializeField(s, nameof(idleSelectedScale));
			SerializeField(s, nameof(idleSelectedPulseFrequency));
			SerializeField(s, nameof(is2dActor));
			SerializeField(s, nameof(actorScaleSmoothFactor));
			SerializeField(s, nameof(minActorScale));
		}
		public override uint? ClassCRC => 0x28D297A0;
	}
}


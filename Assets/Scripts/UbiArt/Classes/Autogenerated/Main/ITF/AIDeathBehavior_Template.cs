using UnityEngine;

namespace UbiArt.ITF {
	public partial class AIDeathBehavior_Template : AIPlayActionsBehavior_Template {
		[Serialize("pauseComponentWhenDone")] public bool pauseComponentWhenDone;
		[Serialize("pauseActorWhenDone"    )] public bool pauseActorWhenDone;
		[Serialize("destroyActorWhenDone"  )] public bool destroyActorWhenDone;
		[Serialize("deactivatePhysics"     )] public bool deactivatePhysics;
		[Serialize("nullWeight"            )] public bool nullWeight;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(pauseComponentWhenDone));
			SerializeField(s, nameof(pauseActorWhenDone));
			SerializeField(s, nameof(destroyActorWhenDone));
			SerializeField(s, nameof(deactivatePhysics));
			SerializeField(s, nameof(nullWeight));
		}
		public override uint? ClassCRC => 0x961AB13C;
	}
}


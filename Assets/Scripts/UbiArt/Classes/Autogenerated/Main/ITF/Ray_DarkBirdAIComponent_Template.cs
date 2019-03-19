using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_DarkBirdAIComponent_Template : CSerializable {
		[Serialize("appear3dOffset"       )] public Vector3 appear3dOffset;
		[Serialize("detachOnDeath"        )] public int detachOnDeath;
		[Serialize("disappear3dBehavior"  )] public Placeholder disappear3dBehavior;
		[Serialize("triggerBounceBehavior")] public Placeholder triggerBounceBehavior;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(appear3dOffset));
			SerializeField(s, nameof(detachOnDeath));
			SerializeField(s, nameof(disappear3dBehavior));
			SerializeField(s, nameof(triggerBounceBehavior));
		}
		public override uint? ClassCRC => 0x25D475DF;
	}
}


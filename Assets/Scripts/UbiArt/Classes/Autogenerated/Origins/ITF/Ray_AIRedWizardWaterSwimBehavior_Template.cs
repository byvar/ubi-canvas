using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_AIRedWizardWaterSwimBehavior_Template : BlendTreeNodeTemplate<Q23ITF14AnimTreeResult> {
		[Serialize("minSpeed" )] public float minSpeed;
		[Serialize("maxSpeed" )] public float maxSpeed;
		[Serialize("minForce" )] public float minForce;
		[Serialize("maxForce" )] public float maxForce;
		[Serialize("moveForce")] public float moveForce;
		[Serialize("swim"     )] public Placeholder swim;
		[Serialize("jump"     )] public Placeholder jump;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(minSpeed));
			SerializeField(s, nameof(maxSpeed));
			SerializeField(s, nameof(minForce));
			SerializeField(s, nameof(maxForce));
			SerializeField(s, nameof(moveForce));
			SerializeField(s, nameof(swim));
			SerializeField(s, nameof(jump));
		}
		public override uint? ClassCRC => 0xC105379D;
	}
}


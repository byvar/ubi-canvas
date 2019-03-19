using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_455_sub_B8C010 : CSerializable {
		[Serialize("vacuumSkill"      )] public Placeholder vacuumSkill;
		[Serialize("waitAction"       )] public Placeholder waitAction;
		[Serialize("vacuumAction"     )] public Placeholder vacuumAction;
		[Serialize("spitAction"       )] public Placeholder spitAction;
		[Serialize("spitMarker"       )] public StringID spitMarker;
		[Serialize("spitBoneName"     )] public StringID spitBoneName;
		[Serialize("spitForce"        )] public Vector2 spitForce;
		[Serialize("startVacuumMarker")] public StringID startVacuumMarker;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(vacuumSkill));
			SerializeField(s, nameof(waitAction));
			SerializeField(s, nameof(vacuumAction));
			SerializeField(s, nameof(spitAction));
			SerializeField(s, nameof(spitMarker));
			SerializeField(s, nameof(spitBoneName));
			SerializeField(s, nameof(spitForce));
			SerializeField(s, nameof(startVacuumMarker));
		}
		public override uint? ClassCRC => 0x61CB6C6F;
	}
}


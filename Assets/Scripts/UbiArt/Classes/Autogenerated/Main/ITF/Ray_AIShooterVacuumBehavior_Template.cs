using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AIShooterVacuumBehavior_Template : TemplateAIBehavior {
		[Serialize("vacuumSkill"      )] public VacuumSkill_Template vacuumSkill;
		[Serialize("waitAction"       )] public Generic<AIAction_Template> waitAction;
		[Serialize("vacuumAction"     )] public Generic<AIAction_Template> vacuumAction;
		[Serialize("spitAction"       )] public Generic<AIAction_Template> spitAction;
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
		public override uint? ClassCRC => 0xBBE22808;
	}
}


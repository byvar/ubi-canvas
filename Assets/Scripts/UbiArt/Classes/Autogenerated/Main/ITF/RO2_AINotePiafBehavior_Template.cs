using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_AINotePiafBehavior_Template : TemplateAIBehavior {
		[Serialize("weightThreshold"  )] public float weightThreshold;
		[Serialize("flyBackDelay"     )] public float flyBackDelay;
		[Serialize("fallBreakDelay"   )] public float fallBreakDelay;
		[Serialize("appear3dOffset"   )] public Vector3 appear3dOffset;
		[Serialize("isBumper"         )] public bool isBumper;
		[Serialize("standAction"      )] public Generic<AIAction_Template> standAction;
		[Serialize("fallResistAction" )] public Generic<AIAction_Template> fallResistAction;
		[Serialize("catchAction"      )] public Generic<AIAction_Template> catchAction;
		[Serialize("fallBreakAction"  )] public Generic<AIAction_Template> fallBreakAction;
		[Serialize("appear3dAction"   )] public Generic<AIAction_Template> appear3dAction;
		[Serialize("disappear3dAction")] public Generic<AIAction_Template> disappear3dAction;
		[Serialize("flyBackAction"    )] public Generic<AIAction_Template> flyBackAction;
		[Serialize("landAction"       )] public Generic<AIAction_Template> landAction;
		[Serialize("pseudoDeathAction")] public Generic<AIAction_Template> pseudoDeathAction;
		[Serialize("noteFxNames"      )] public Placeholder noteFxNames;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(weightThreshold));
				SerializeField(s, nameof(flyBackDelay));
				SerializeField(s, nameof(fallBreakDelay));
				SerializeField(s, nameof(appear3dOffset));
				SerializeField(s, nameof(isBumper));
				SerializeField(s, nameof(noteFxNames));
				SerializeField(s, nameof(standAction));
				SerializeField(s, nameof(fallResistAction));
				SerializeField(s, nameof(catchAction));
				SerializeField(s, nameof(fallBreakAction));
				SerializeField(s, nameof(appear3dAction));
				SerializeField(s, nameof(disappear3dAction));
				SerializeField(s, nameof(flyBackAction));
				SerializeField(s, nameof(landAction));
				SerializeField(s, nameof(pseudoDeathAction));
			} else {
				SerializeField(s, nameof(weightThreshold));
				SerializeField(s, nameof(flyBackDelay));
				SerializeField(s, nameof(fallBreakDelay));
				SerializeField(s, nameof(appear3dOffset));
				SerializeField(s, nameof(isBumper));
				SerializeField(s, nameof(standAction));
				SerializeField(s, nameof(fallResistAction));
				SerializeField(s, nameof(catchAction));
				SerializeField(s, nameof(fallBreakAction));
				SerializeField(s, nameof(appear3dAction));
				SerializeField(s, nameof(disappear3dAction));
				SerializeField(s, nameof(flyBackAction));
				SerializeField(s, nameof(landAction));
				SerializeField(s, nameof(pseudoDeathAction));
			}
		}
		public override uint? ClassCRC => 0x38D585E0;
	}
}


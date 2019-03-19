using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AINotePiafBehavior_Template : BlendTreeNodeTemplate<Q23ITF14AnimTreeResult> {
		[Serialize("weightThreshold"  )] public float weightThreshold;
		[Serialize("flyBackDelay"     )] public float flyBackDelay;
		[Serialize("fallBreakDelay"   )] public float fallBreakDelay;
		[Serialize("appear3dOffset"   )] public Vector3 appear3dOffset;
		[Serialize("isBumper"         )] public int isBumper;
		[Serialize("noteFxNames"      )] public Placeholder noteFxNames;
		[Serialize("standAction"      )] public Placeholder standAction;
		[Serialize("fallResistAction" )] public Placeholder fallResistAction;
		[Serialize("catchAction"      )] public Placeholder catchAction;
		[Serialize("fallBreakAction"  )] public Placeholder fallBreakAction;
		[Serialize("appear3dAction"   )] public Placeholder appear3dAction;
		[Serialize("disappear3dAction")] public Placeholder disappear3dAction;
		[Serialize("flyBackAction"    )] public Placeholder flyBackAction;
		[Serialize("landAction"       )] public Placeholder landAction;
		[Serialize("pseudoDeathAction")] public Placeholder pseudoDeathAction;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
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
		}
		public override uint? ClassCRC => 0x4BDD804F;
	}
}


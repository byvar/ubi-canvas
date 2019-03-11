using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BTActionLookAtAttack_Template : BTAction_Template {
		[Serialize("enemyDetectionRange")] public Generic<PhysShape> enemyDetectionRange;
		[Serialize("enemyAttackRange"   )] public Generic<PhysShape> enemyAttackRange;
		[Serialize("detectAnim"         )] public StringID detectAnim;
		[Serialize("attackAnim"         )] public StringID attackAnim;
		[Serialize("lookAtBlend"        )] public float lookAtBlend;
		[Serialize("debug"              )] public bool debug;
		[Serialize("fxNames"            )] public CList<StringID> fxNames;
		[Serialize("fxMarkerStart"      )] public CList<StringID> fxMarkerStart;
		[Serialize("fxMarkerStop"       )] public CList<StringID> fxMarkerStop;
		[Serialize("lightningStart"     )] public StringID lightningStart;
		[Serialize("lightningStop"      )] public StringID lightningStop;
		[Serialize("lightningCharge"    )] public StringID lightningCharge;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(enemyDetectionRange));
			SerializeField(s, nameof(enemyAttackRange));
			SerializeField(s, nameof(detectAnim));
			SerializeField(s, nameof(attackAnim));
			SerializeField(s, nameof(lookAtBlend));
			SerializeField(s, nameof(debug));
			SerializeField(s, nameof(fxNames));
			SerializeField(s, nameof(fxMarkerStart));
			SerializeField(s, nameof(fxMarkerStop));
			SerializeField(s, nameof(lightningStart));
			SerializeField(s, nameof(lightningStop));
			SerializeField(s, nameof(lightningCharge));
		}
		public override uint? ClassCRC => 0x9A0B94EA;
	}
}

